namespace LaserUI
{
    partial class frmRunStock
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
            this.laserstockitemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_databaseDataSet = new LaserUI.order_databaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.laser_stock_itemsTableAdapter = new LaserUI.order_databaseDataSetTableAdapters.laser_stock_itemsTableAdapter();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.cviewlaserstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new LaserUI.user_infoDataSet();
            this.c_view_laser_staffTableAdapter = new LaserUI.user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter();
            this.lstItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.laserstockitemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // laserstockitemsBindingSource
            // 
            this.laserstockitemsBindingSource.DataMember = "laser_stock_items";
            this.laserstockitemsBindingSource.DataSource = this.order_databaseDataSet;
            // 
            // order_databaseDataSet
            // 
            this.order_databaseDataSet.DataSetName = "order_databaseDataSet";
            this.order_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Stock Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Staff Member";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(280, 58);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.Size = new System.Drawing.Size(809, 497);
            this.dg.TabIndex = 4;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(477, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // laser_stock_itemsTableAdapter
            // 
            this.laser_stock_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStaff
            // 
            this.cmbStaff.DataSource = this.cviewlaserstaffBindingSource;
            this.cmbStaff.DisplayMember = "FullName";
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(280, 31);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(191, 21);
            this.cmbStaff.TabIndex = 6;
            this.cmbStaff.ValueMember = "id";
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
            // c_view_laser_staffTableAdapter
            // 
            this.c_view_laser_staffTableAdapter.ClearBeforeFill = true;
            // 
            // lstItems
            // 
            this.lstItems.DataSource = this.laserstockitemsBindingSource;
            this.lstItems.DisplayMember = "description";
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(8, 31);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(261, 524);
            this.lstItems.TabIndex = 7;
            this.lstItems.ValueMember = "id";
            // 
            // frmRunStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 563);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRunStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Stock";
            this.Load += new System.EventHandler(this.frmRunStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laserstockitemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cviewlaserstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnStart;
        private order_databaseDataSet order_databaseDataSet;
        private System.Windows.Forms.BindingSource laserstockitemsBindingSource;
        private order_databaseDataSetTableAdapters.laser_stock_itemsTableAdapter laser_stock_itemsTableAdapter;
        private System.Windows.Forms.ComboBox cmbStaff;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource cviewlaserstaffBindingSource;
        private user_infoDataSetTableAdapters.c_view_laser_staffTableAdapter c_view_laser_staffTableAdapter;
        private System.Windows.Forms.ListBox lstItems;
    }
}