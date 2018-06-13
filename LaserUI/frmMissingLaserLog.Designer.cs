namespace LaserUI
{
    partial class frmMissingLaserLog
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
            this.components = new System.ComponentModel.Container();
            this.txtDoorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.laserpartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new LaserUI.order_databaseDataSet();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.laser_partsTableAdapter = new LaserUI.order_databaseDataSetTableAdapters.laser_partsTableAdapter();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondsPerPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.user_infoDataSet = new LaserUI.user_infoDataSet();
            this.cviewlaserstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c_view_laser_staffTableAdapter = new LaserUI.user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.laserpartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoorID
            // 
            this.txtDoorID.Location = new System.Drawing.Point(64, 12);
            this.txtDoorID.Name = "txtDoorID";
            this.txtDoorID.Size = new System.Drawing.Size(67, 20);
            this.txtDoorID.TabIndex = 0;
            this.txtDoorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Door ID";
            // 
            // lstItems
            // 
            this.lstItems.DataSource = this.laserpartsBindingSource;
            this.lstItems.DisplayMember = "part_description";
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(17, 71);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(259, 316);
            this.lstItems.TabIndex = 2;
            this.lstItems.ValueMember = "id";
            this.lstItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseDoubleClick);
            // 
            // laserpartsBindingSource
            // 
            this.laserpartsBindingSource.DataMember = "laser_parts";
            this.laserpartsBindingSource.DataSource = this.orderdatabaseDataSetBindingSource;
            // 
            // orderdatabaseDataSetBindingSource
            // 
            this.orderdatabaseDataSetBindingSource.DataSource = this.order_databaseDataSet;
            this.orderdatabaseDataSetBindingSource.Position = 0;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dg
            // 
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.PartName,
            this.Quantity,
            this.secondsPerPart});
            this.dg.Location = new System.Drawing.Point(293, 71);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(508, 316);
            this.dg.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(728, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // laser_partsTableAdapter
            // 
            this.laser_partsTableAdapter.ClearBeforeFill = true;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "PartID";
            this.PartID.Name = "PartID";
            // 
            // PartName
            // 
            this.PartName.HeaderText = "PartName";
            this.PartName.Name = "PartName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // secondsPerPart
            // 
            this.secondsPerPart.HeaderText = "secondsPerPart";
            this.secondsPerPart.Name = "secondsPerPart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff";
            // 
            // cmbStaff
            // 
            this.cmbStaff.DataSource = this.cviewlaserstaffBindingSource;
            this.cmbStaff.DisplayMember = "FullName";
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(64, 42);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(212, 21);
            this.cmbStaff.TabIndex = 5;
            this.cmbStaff.ValueMember = "id";
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cviewlaserstaffBindingSource
            // 
            this.cviewlaserstaffBindingSource.DataMember = "c_view_laser_staff";
            this.cviewlaserstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // c_view_laser_staffTableAdapter
            // 
            this.c_view_laser_staffTableAdapter.ClearBeforeFill = true;
            // 
            // frmMissingLaserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoorID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMissingLaserLog";
            this.Text = "Missing Laser Log";
            this.Load += new System.EventHandler(this.frmMissingLaserLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laserpartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource orderdatabaseDataSetBindingSource;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource laserpartsBindingSource;
        private order_databaseDataSetTableAdapters.laser_partsTableAdapter laser_partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondsPerPart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStaff;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewlaserstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter c_view_laser_staffTableAdapter;
    }
}