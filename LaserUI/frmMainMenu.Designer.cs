namespace LaserUI
{
    partial class frmMainMenu
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
            this.dgvDoors = new System.Windows.Forms.DataGridView();
            this.grpView = new System.Windows.Forms.GroupBox();
            this.rdoAheadOfTime = new System.Windows.Forms.RadioButton();
            this.rdoLateToday = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.runStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPrintRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missingDoorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoors)).BeginInit();
            this.grpView.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoors
            // 
            this.dgvDoors.AllowUserToAddRows = false;
            this.dgvDoors.AllowUserToDeleteRows = false;
            this.dgvDoors.AllowUserToResizeColumns = false;
            this.dgvDoors.AllowUserToResizeRows = false;
            this.dgvDoors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoors.Location = new System.Drawing.Point(13, 152);
            this.dgvDoors.Name = "dgvDoors";
            this.dgvDoors.ReadOnly = true;
            this.dgvDoors.RowHeadersVisible = false;
            this.dgvDoors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoors.Size = new System.Drawing.Size(957, 440);
            this.dgvDoors.TabIndex = 0;
            this.dgvDoors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoors_CellContentClick);
            // 
            // grpView
            // 
            this.grpView.Controls.Add(this.rdoAheadOfTime);
            this.grpView.Controls.Add(this.rdoLateToday);
            this.grpView.Location = new System.Drawing.Point(17, 68);
            this.grpView.Name = "grpView";
            this.grpView.Size = new System.Drawing.Size(209, 75);
            this.grpView.TabIndex = 1;
            this.grpView.TabStop = false;
            this.grpView.Text = "View";
            // 
            // rdoAheadOfTime
            // 
            this.rdoAheadOfTime.AutoSize = true;
            this.rdoAheadOfTime.Location = new System.Drawing.Point(7, 43);
            this.rdoAheadOfTime.Name = "rdoAheadOfTime";
            this.rdoAheadOfTime.Size = new System.Drawing.Size(93, 17);
            this.rdoAheadOfTime.TabIndex = 1;
            this.rdoAheadOfTime.Text = "Ahead of time:";
            this.rdoAheadOfTime.UseVisualStyleBackColor = true;
            this.rdoAheadOfTime.CheckedChanged += new System.EventHandler(this.rdoAheadOfTime_CheckedChanged);
            // 
            // rdoLateToday
            // 
            this.rdoLateToday.AutoSize = true;
            this.rdoLateToday.Checked = true;
            this.rdoLateToday.Location = new System.Drawing.Point(7, 20);
            this.rdoLateToday.Name = "rdoLateToday";
            this.rdoLateToday.Size = new System.Drawing.Size(104, 17);
            this.rdoLateToday.TabIndex = 0;
            this.rdoLateToday.TabStop = true;
            this.rdoLateToday.Text = "Lates and today:";
            this.rdoLateToday.UseVisualStyleBackColor = true;
            this.rdoLateToday.CheckedChanged += new System.EventHandler(this.rdoLateToday_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(886, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(84, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(839, 99);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(41, 13);
            this.lblsearch.TabIndex = 3;
            this.lblsearch.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runStockToolStripMenuItem,
            this.sendPrintRequestToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.missingDoorLogToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // runStockToolStripMenuItem
            // 
            this.runStockToolStripMenuItem.Name = "runStockToolStripMenuItem";
            this.runStockToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.runStockToolStripMenuItem.Text = "Run Stock";
            this.runStockToolStripMenuItem.Click += new System.EventHandler(this.runStockToolStripMenuItem_Click);
            // 
            // sendPrintRequestToolStripMenuItem
            // 
            this.sendPrintRequestToolStripMenuItem.Name = "sendPrintRequestToolStripMenuItem";
            this.sendPrintRequestToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.sendPrintRequestToolStripMenuItem.Text = "Send Print Request";
            this.sendPrintRequestToolStripMenuItem.Click += new System.EventHandler(this.sendPrintRequestToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // missingDoorLogToolStripMenuItem
            // 
            this.missingDoorLogToolStripMenuItem.Name = "missingDoorLogToolStripMenuItem";
            this.missingDoorLogToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.missingDoorLogToolStripMenuItem.Text = "Missing Door Log";
            this.missingDoorLogToolStripMenuItem.Click += new System.EventHandler(this.missingDoorLogToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.ImageLocation = "\\\\designsvr1\\apps\\tom\\Company Logo\\logo files\\logo.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(415, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(886, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 24);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 604);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpView);
            this.Controls.Add(this.dgvDoors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoors)).EndInit();
            this.grpView.ResumeLayout(false);
            this.grpView.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoors;
        private System.Windows.Forms.GroupBox grpView;
        private System.Windows.Forms.RadioButton rdoAheadOfTime;
        private System.Windows.Forms.RadioButton rdoLateToday;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem runStockToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem sendPrintRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missingDoorLogToolStripMenuItem;
    }
}