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
    public partial class frmNotes : Form
    {

        private double _doorID { get; set; }


        public frmNotes(double door_Id)
        {
            InitializeComponent();
            _doorID = door_Id;
            lblHeader.Text = "Laser notes for door number: " + _doorID;
            fillNotes();
        }

        private void frmNotes_Load(object sender, EventArgs e)
        {

        }



        private void fillNotes()
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT laser_note from dbo.door where id = @doorId;";
            cmd.Parameters.AddWithValue("@doorID", _doorID);

            txtNotes.Text = cmd.ExecuteScalar().ToString();

            conn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(SqlStatements.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "UPDATE dbo.door set laser_note = @note where id =@doorID";
            cmd.Parameters.AddWithValue("@doorID", _doorID);
            cmd.Parameters.AddWithValue("@note", txtNotes.Text);

            cmd.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }
    }
}
