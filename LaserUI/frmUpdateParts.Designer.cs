namespace LaserUI
{
    partial class frmUpdateParts
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cviewlaserstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new LaserUI.user_infoDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.c_view_laser_staffTableAdapter = new LaserUI.user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(13, 54);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.Size = new System.Drawing.Size(458, 326);
            this.dg.TabIndex = 0;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // cmbStaff
            // 
            this.cmbStaff.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.cviewlaserstaffBindingSource, "FullName", true));
            this.cmbStaff.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cviewlaserstaffBindingSource, "id", true));
            this.cmbStaff.DataSource = this.cviewlaserstaffBindingSource;
            this.cmbStaff.DisplayMember = "FullName";
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(280, 27);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(191, 21);
            this.cmbStaff.TabIndex = 1;
            this.cmbStaff.ValueMember = "id";
            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            // 
            // cviewlaserstaffBindingSource
            // 
            this.cviewlaserstaffBindingSource.DataMember = "c_view_laser_staff";
            this.cviewlaserstaffBindingSource.DataSource = this.user_infoDataSet;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Staff";
            // 
            // c_view_laser_staffTableAdapter
            // 
            this.c_view_laser_staffTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.dg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateParts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Door Parts";
            this.Load += new System.EventHandler(this.frmUpdateParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label1;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewlaserstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter c_view_laser_staffTableAdapter;
    }
}