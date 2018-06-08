using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LaserLib;

namespace LaserUI
{
    public partial class frmUpdateParts : Form
    {
        public int _doorID { get; set; }
        private DateTime _UpdateDate{ get; set;}



       



        public frmUpdateParts(int doorID)
        {
            InitializeComponent();
            _doorID = doorID;
            _UpdateDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000"));
            dg.CellClick += dg_CellClick;
            fillGrid();

            dg.Columns["id"].Visible = false;
            dg.Columns["door_id"].Visible = false;
            dg.Columns["minutes_to_add"].Visible = false;
            dg.Columns["hours_to_add"].Visible = false;
           
        }

        private void frmUpdateParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_laser_staff' table. You can move, or remove it, as needed.
            this.c_view_laser_staffTableAdapter.Fill(this.user_infoDataSet.c_view_laser_staff);
            cmbStaff.SelectedIndex = -1;

        }


        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

  


            cmd.CommandText = "Select * from c_view_laser_parts where door_id = @doorID;";
          
            cmd.Parameters.AddWithValue("@doorID", _doorID);
            


            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            try
            {

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dg.DataSource = dt;

                DataGridViewButtonColumn noteButton = new DataGridViewButtonColumn();
                noteButton.Text = "Complete";
                noteButton.Name = "Complete";
                noteButton.UseColumnTextForButtonValue = true;
                int columnIndex = 7;

                if (dg.Columns["Complete"] == null)
                {
                    dg.Columns.Insert(columnIndex, noteButton);
                }

            }
            catch (Exception)
            {
                // MessageBox.Show("Please ensure you enter a valid description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int doorID = 0;
            int id = 0;
            double hourTA=0;
            double minuteTA=0;
            string part = "";
            



            if (dg.SelectedCells.Count > 0)
            {
                int selectedrowindex = dg.SelectedCells[0].RowIndex;
              
                DataGridViewRow selectedRow = dg.Rows[selectedrowindex];

                doorID = Convert.ToInt32(selectedRow.Cells["door_id"].Value);
                id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                hourTA = Convert.ToDouble(selectedRow.Cells["hours_to_add"].Value);
                minuteTA = Convert.ToDouble(selectedRow.Cells["minutes_to_add"].Value);
                part = selectedRow.Cells["part_description"].Value.ToString();

            }

            if(cmbStaff.SelectedIndex != -1)
            {
                if (e.ColumnIndex == dg.Columns["Complete"].Index)
                {

                    DialogResult result;
                    result = MessageBox.Show("Are you sure you wish to mark this part as complete? This cannot be undone!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                        conn.Open();

                        //UPDATES THE LASER PART
                        SqlCommand cmdPart = new SqlCommand();
                        cmdPart.Connection = conn;

                        cmdPart.CommandText = "UPDATE dbo.door_program_laser_parts SET part_complete = -1 where id = @id;";
                        cmdPart.Parameters.AddWithValue("@id", id);
                        cmdPart.ExecuteNonQuery();


                        //UPDATES DAILY GOALS
                        SqlCommand cmddailyGoal = new SqlCommand();
                        cmddailyGoal.Connection = conn;

                        cmddailyGoal.CommandText = "UPDATE dbo.daily_department_goal SET actual_hours_laser = actual_hours_laser + @hours where date_goal = @date;";
                        cmddailyGoal.Parameters.AddWithValue("@hours", hourTA);
                        cmddailyGoal.Parameters.AddWithValue("@date", _UpdateDate);
                        cmddailyGoal.ExecuteNonQuery();

                        //updates completion log

                        SqlCommand cmdLog = new SqlCommand();
                        cmdLog.Connection = conn;

                        cmdLog.CommandText = "INSERT INTO dbo.door_part_completion_log(staff_id,door_id,part_complete_date,time_for_part,part,part_status,op) " +
                                             "VALUES (@staffID,@doorID,@partCompleteDate,@timeForPart,@part,'Complete','Laser');";

                        cmdLog.Parameters.AddWithValue("@staffID", cmbStaff.Text);
                        cmdLog.Parameters.AddWithValue("@doorID", _doorID);
                        cmdLog.Parameters.AddWithValue("@partCompleteDate", DateTime.Now);
                        cmdLog.Parameters.AddWithValue("@timeForPart", minuteTA);
                        cmdLog.Parameters.AddWithValue("@part", part);

                        cmdLog.ExecuteNonQuery();

                        conn.Close();

                        checkComplete();
                        check100();

                    }
                }

            

                fillGrid();
            }
            else
            {
                MessageBox.Show("Please select a staff member before marking a part as complete", "Select staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void check100()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            //UPDATES THE LASER PART
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT actual_hours_laser / goal_hours_laser as percentage_laser from dbo.daily_department_goal where date_goal = @date ;";
            cmd.Parameters.AddWithValue("@date", _UpdateDate);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                if (Convert.ToDecimal(rdr["percentage_laser"]) > 1)
                {
                    SqlCommand cmdWrite = new SqlCommand();
                    cmdWrite.Connection = conn;
                    cmdWrite.CommandText = "UPDATE dbo.daily_department_goal set time_100_percent_laser = @now WHERE date_goal = @date;";
                    cmd.Parameters.AddWithValue("@now", DateTime.Now);
                    cmd.Parameters.AddWithValue("@date", _UpdateDate);

                    cmd.ExecuteNonQuery();
                }
            }

            conn.Close();

        }

        private void checkComplete()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            //UPDATES THE LASER PART
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM dbo.door_program_laser_parts WHERE door_id=@doorID and (part_complete=0 or part_complete is null);";

            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.Read())
            {

            }
            else
            {
                SqlCommand cmdWrite = new SqlCommand();
                cmdWrite.Connection = conn;
                cmdWrite.CommandText = "UPDATE dbo.door set complete_laser = -1 where id =@doorID";
                cmdWrite.Parameters.AddWithValue("@doorID", _doorID);
                cmd.ExecuteNonQuery();
              
            }

            conn.Close();

           
        }



    }
}
