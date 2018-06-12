using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using LaserLib;


namespace LaserUI
{
    public partial class FrmlaserLateReport : Form
    {
        public FrmlaserLateReport()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Fill_data();
        }
        void Fill_data()
        {
            DataSet ds = new DataSet();
            
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);


            SqlCommand cmd = new SqlCommand();
           
            cmd.Connection = conn;

            cmd.CommandText = "SELECT id,NAME, date_laser, door_type_description,quantity_same,lead_time, program_date,laser_program_date, date_weld, date_completion,fullname from c_view_laser_late_report  order by date_laser";
            //cmd.Parameters.AddWithValue("@date", DateTime.Now);

            SqlDataAdapter adap = new SqlDataAdapter(cmd);


            adap.Fill(ds);



            RptLaserLate1.SetDatabaseLogon("sa", "Dodid1");
            RptLaserLate1.SetDataSource(ds.Tables[0]);

            crystalReportViewer1.ReportSource = RptLaserLate1;

            crystalReportViewer1.Refresh();

            


        }
    }
}
