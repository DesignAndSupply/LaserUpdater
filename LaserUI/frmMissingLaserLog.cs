using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaserLib;
using System.Data.SqlClient;

namespace LaserUI
{
    public partial class frmMissingLaserLog : Form
    {

        public double _timeInGrid { get; set; }

        public frmMissingLaserLog()
        {
            InitializeComponent();
        }

        private void frmMissingLaserLog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_laser_staff' table. You can move, or remove it, as needed.
            this.c_view_laser_staffTableAdapter.Fill(this.user_infoDataSet.c_view_laser_staff);
            // TODO: This line of code loads data into the 'order_databaseDataSet.laser_parts' table. You can move, or remove it, as needed.
            this.laser_partsTableAdapter.Fill(this.order_databaseDataSet.laser_parts);
            cmbStaff.SelectedIndex = -1;

        }

        private void lstItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.dg.Rows.Add(lstItems.SelectedValue, (lstItems.SelectedItem as DataRowView)["part_description"].ToString(), 1, (lstItems.SelectedItem as DataRowView)["seconds_per_part"].ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            double n;
            bool isNumeric = Double.TryParse(txtDoorID.Text, out n);

            if (dg.Rows.Count == 0 || isNumeric == false || cmbStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure that both a door number has been entered, there are parts in the grid and that time you have selected a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
                conn.Open();


                //UPDATES THE DOOR
                SqlCommand cmd = new SqlCommand("update dbo.door set complete_laser = -1, date_laser_complete = @now where id=@doorID",conn);
                cmd.Parameters.AddWithValue("@now", DateTime.Now);
                cmd.Parameters.AddWithValue("@doorID", n);

                cmd.ExecuteNonQuery();

                //UPDATES THE MISSING DOOR LOG
                SqlCommand cmdLog = new SqlCommand("INSERT into dbo.laser_missing (door_id, log_date) VALUES(@doorID, @now)",conn);
                cmdLog.Parameters.AddWithValue("@now", DateTime.Now);
                cmdLog.Parameters.AddWithValue("@doorID", n);
                cmdLog.ExecuteNonQuery();


                //GETS THE TIME IN THE GRID

                timeInGrid();


                //UPDATES DAILY GOALS
                SqlCommand cmddailyGoal = new SqlCommand();
                cmddailyGoal.Connection = conn;

                cmddailyGoal.CommandText = "UPDATE dbo.daily_department_goal SET actual_hours_laser = actual_hours_laser + @hours where date_goal = @date;";
                cmddailyGoal.Parameters.AddWithValue("@hours", (_timeInGrid / 60) / 60 );
                cmddailyGoal.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")));
                cmddailyGoal.ExecuteNonQuery();

               

                //updates completion log

                SqlCommand cmdPLog = new SqlCommand();
                cmdPLog.Connection = conn;

                cmdPLog.CommandText = "INSERT INTO dbo.door_part_completion_log(staff_id,door_id,part_complete_date,time_for_part,part,part_status,op) " +
                                     "VALUES (@staffID,@doorID,@partCompleteDate,@timeForPart,@part,'Complete','Laser');";

                cmdPLog.Parameters.AddWithValue("@staffID", cmbStaff.SelectedValue);
                cmdPLog.Parameters.AddWithValue("@doorID", n);
                cmdPLog.Parameters.AddWithValue("@partCompleteDate", DateTime.Now);
                cmdPLog.Parameters.AddWithValue("@timeForPart", _timeInGrid / 60);
                cmdPLog.Parameters.AddWithValue("@part", "Missing Items");
                cmdPLog.ExecuteNonQuery();

                this.Close();
            }
        }


        private void timeInGrid()
        {
            foreach (DataGridViewRow r in dg.Rows)
            {
                _timeInGrid = _timeInGrid + (Convert.ToDouble(r.Cells["quantity"].Value) * Convert.ToDouble(r.Cells["secondsPerPart"].Value));
            }


        }


    }
}
