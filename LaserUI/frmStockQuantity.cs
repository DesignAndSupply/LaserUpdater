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
    public partial class frmStockQuantity : Form
    {

        public int _sessionID { get; set; }



        public double _timeForPart { get
            {

                SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);

                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT sec_per_item FROM dbo.laser_stock_session_parts INNER JOIN dbo.laser_stock_items ON dbo.laser_stock_session_parts.part_id = dbo.laser_stock_items.id where session_id = @sessionID",conn);
                cmd.Parameters.AddWithValue("@sessionID", _sessionID);

                return Convert.ToDouble(cmd.ExecuteScalar());

            }

            }


        public frmStockQuantity(int sessionID)
        {
            InitializeComponent();
            _sessionID = sessionID;
        }


        private void updateSession()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            double timeToInsert = Math.Round((Convert.ToDouble(txtQuantity.Text) * _timeForPart) / 60, 2);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE dbo.laser_stock_session SET session_status_id=2,date_complete= @now, total_items_complete =@qty, total_time=@time WHERE id = @id;";
            cmd.Parameters.AddWithValue("@id", _sessionID);
            cmd.Parameters.AddWithValue("@now", DateTime.Now);
            cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@time", timeToInsert);

            cmd.ExecuteNonQuery();

        }

        private void updateGoals()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            double timeToInsert = Math.Round((Convert.ToDouble(txtQuantity.Text) * _timeForPart) / 60, 2);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE dbo.daily_department_goal SET actual_hours_laser = actual_hours_laser + @time where date_goal = @date";
        
            cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00.000")));
            
            cmd.Parameters.AddWithValue("@time", timeToInsert /60 );

            cmd.ExecuteNonQuery();

        }


        private void frmStockQuantity_Load(object sender, EventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            double n;
            bool isNumeric = Double.TryParse(txtQuantity.Text, out n);

            if (isNumeric==true)
            {
                updateSession();
                updateGoals();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a numerical value to continue!", "Non numerical value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
