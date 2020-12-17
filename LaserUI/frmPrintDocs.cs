using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserUI
{
    public partial class frmPrintDocs : Form
    {
        public frmPrintDocs()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filepath = "";
            OpenFileDialog openFileName = new OpenFileDialog();
            openFileName.FilterIndex = 1;
            openFileName.InitialDirectory = @"\\DESIGNSVR1\Public\Scanned Laser\Old";
            openFileName.RestoreDirectory = true;

            if (openFileName.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filepath = openFileName.FileName;

                }
                catch
                {
                    MessageBox.Show("Error loading file, please check the filetype is correct."); // doesnr seem to proc this and the viewer itself will throw an error (unless its some funky file format mayb?)
                }
            }

            axAcroPDF1.src = filepath;
            axAcroPDF1.setShowToolbar(false); //remove annoying toolbar
        }
    }
}
