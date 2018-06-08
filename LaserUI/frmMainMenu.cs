﻿using System;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
            dgvDoors.CellClick += dgvDoors_CellClick;

            fillGrid();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }
        private void fillGrid()
        {
            //UPDATES OPERATIONS DATAGRID
            SqlConnection con = new SqlConnection(SqlStatements.ConnectionString);


            //UPDATES THE PAINT TO DOOR DATAGRID
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (rdoAheadOfTime.Checked == true)
                {
                    cmd.CommandText = "Select * from c_view_laser_load where date_laser > @plannedDate order by date_laser;";
                    cmd.Parameters.AddWithValue("@plannedDate", DateTime.Today);
                }
                else
                {
                    cmd.CommandText = "Select * from c_view_laser_load where date_laser <= @plannedDate order by date_laser;";
                    cmd.Parameters.AddWithValue("@plannedDate", DateTime.Today);

                }

            }
            else
            {
                cmd.CommandText = "Select * from c_view_laser_load where id = @doorId order by date_laser;";
                cmd.Parameters.AddWithValue("@plannedDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@doorID", txtSearch.Text);
            }


            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            try
            {

                DataTable dt = new DataTable();
                adap.Fill(dt);
                dgvDoors.DataSource = dt;

                DataGridViewButtonColumn noteButton = new DataGridViewButtonColumn();
                noteButton.Text = "Add Note";
                noteButton.Name = "Add Note";
                noteButton.UseColumnTextForButtonValue = true;
                int columnIndex = 8;

                if (dgvDoors.Columns["Add Note"] == null)
                {
                    dgvDoors.Columns.Insert(columnIndex, noteButton);
                }


                DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
                updateButton.Text = "Update Door";
                updateButton.Name = "Update Door";
                updateButton.UseColumnTextForButtonValue = true;
                int columnIndex2 = 9;

                if (dgvDoors.Columns["Update Door"] == null)
                {
                    dgvDoors.Columns.Insert(columnIndex2, updateButton);
                }


            }
            catch (Exception)
            {
               // MessageBox.Show("Please ensure you enter a valid description!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdoLateToday_CheckedChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void rdoAheadOfTime_CheckedChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            fillGrid();
        }

        private void dgvDoors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDoors_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int doorID=0;

            if (dgvDoors.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvDoors.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvDoors.Rows[selectedrowindex];

                doorID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                //operation = selectedRow.Cells["Section"].Value.ToString();

            }



            if (e.ColumnIndex == dgvDoors.Columns["Update Door"].Index)
            {
                frmUpdateParts frmUP = new frmUpdateParts(doorID);
                frmUP.ShowDialog();
              
                fillGrid();
            }
        }
    }
}