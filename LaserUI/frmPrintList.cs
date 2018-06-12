using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaserUI
{
    public partial class frmPrintList : Form
    {

        string newLocation = @"\\designsvr1\public\Scanned Laser\New\";
        string oldLocation = @"\\designsvr1\public\Scanned Laser\Old\";
        private StreamReader streamToPrint;
        private Font printFont;

        public frmPrintList()
        {
            InitializeComponent();
            populateList();
        }

        private void frmPrintList_Load(object sender, EventArgs e)
        {

           
        }


        private void populateList()
        {
            DirectoryInfo dinfo = new DirectoryInfo(newLocation);
            FileInfo[] Files = dinfo.GetFiles("*.tif");
            foreach (FileInfo file in Files)
            {
                lstFiles.Items.Add(file.Name);
            }
        }

       
        private void btn_print_Click(object sender, EventArgs e)
        {

                string filename;
                for (int i = 0; i < lstFiles.Items.Count; i++)
                {



                    System.Diagnostics.Process printProcess = new System.Diagnostics.Process();
                    printProcess.StartInfo.FileName = newLocation + lstFiles.Items[i].ToString();
                    printProcess.StartInfo.Verb = "Print";
                    printProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    printProcess.StartInfo.CreateNoWindow = true;
                    printProcess.Start();


                    //filename = newLocation + lstFiles.Items[i].ToString();
                    //this.printDocument1.DocumentName = filename;
                    //this.printDocument1.Print();

                    //System.Threading.Thread.Sleep(5000);



                }

           //populateList();

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFiles.Items.Count; i++)
            {
                File.Move(newLocation + lstFiles.Items[i].ToString(), oldLocation + lstFiles.Items[i].ToString());
            }
        }
    }
}
