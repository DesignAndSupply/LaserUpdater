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
    public partial class frmRunStock : Form
    {
        public frmRunStock()
        {
            InitializeComponent();

            fillData();
        }

        private void frmRunStock_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'user_infoDataSet.c_view_laser_staff' table. You can move, or remove it, as needed.
            this.c_view_laser_staffTableAdapter.Fill(this.user_infoDataSet.c_view_laser_staff);


            // TODO: This line of code loads data into the 'order_databaseDataSet.laser_stock_items' table. You can move, or remove it, as needed.
            this.laser_stock_itemsTableAdapter.Fill(this.order_databaseDataSet.laser_stock_items);

            cmbStaff.SelectedIndex = -1;
            lstItems.SelectedIndex = -1;


        }

        private void fillData()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;



            cmd.CommandText = "Select id as 'Session ID', date_started as 'Date Created' , staff_string as Staff, part_string as Part, total_items_complete as 'Qty Complete', " +
                              "description as Status, date_complete as 'Date Complete' from dbo.view_laser_session order by id desc";
            
              


            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            try
            {

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dg.DataSource = dt;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.Text = "Complete";
                button.Name = "Complete";
                button.UseColumnTextForButtonValue = true;
                int columnIndex = 7;

                if (dg.Columns["Complete"] == null)
                {
                    dg.Columns.Insert(columnIndex, button);
                }

            }
            catch
            {

            }

            }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (cmbStaff.SelectedIndex > -1 && lstItems.SelectedIndex > -1)
            {
                StockSession ss = new StockSession(Convert.ToInt32(lstItems.SelectedValue), Convert.ToInt32(cmbStaff.SelectedValue));
                fillData();

            }
            else
            {
                MessageBox.Show("Please select a staff member and a stock part to continue", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string status="";
            int sessionId = 0;
            DialogResult result;

            if (dg.SelectedCells.Count > 0)
            {
                int selectedrowindex = dg.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dg.Rows[selectedrowindex];

                status = selectedRow.Cells["status"].Value.ToString();
                sessionId = Convert.ToInt32(selectedRow.Cells["Session ID"].Value);

            }

            if (e.ColumnIndex == dg.Columns["Complete"].Index)
            {
                if (status == "Running")
                {
                    result = MessageBox.Show("Are you sure you wish to mark this part as complete? This cannot be undone!", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        frmStockQuantity frm = new frmStockQuantity(sessionId);
                        frm.ShowDialog();
                        fillData();

                    }
                }
                else
                {
                    MessageBox.Show("Please select a stock session that isn't already complete!", "Review selections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
