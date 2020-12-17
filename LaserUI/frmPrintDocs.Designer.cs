namespace LaserUI
{
    partial class frmPrintDocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintDocs));
            this.c_view_laser_late_reportTableAdapter1 = new LaserUI.Datasource.DS_laser_lateTableAdapters.c_view_laser_late_reportTableAdapter();
            this.c_view_laser_late_reportTableAdapter2 = new LaserUI.Datasource.DS_laser_lateTableAdapters.c_view_laser_late_reportTableAdapter();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // c_view_laser_late_reportTableAdapter1
            // 
            this.c_view_laser_late_reportTableAdapter1.ClearBeforeFill = true;
            // 
            // c_view_laser_late_reportTableAdapter2
            // 
            this.c_view_laser_late_reportTableAdapter2.ClearBeforeFill = true;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(12, 58);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(800, 485);
            this.axAcroPDF1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(21, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmPrintDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 573);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.axAcroPDF1);
            this.Name = "frmPrintDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintDocs";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasource.DS_laser_lateTableAdapters.c_view_laser_late_reportTableAdapter c_view_laser_late_reportTableAdapter1;
        private Datasource.DS_laser_lateTableAdapters.c_view_laser_late_reportTableAdapter c_view_laser_late_reportTableAdapter2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Button btnSearch;
    }
}