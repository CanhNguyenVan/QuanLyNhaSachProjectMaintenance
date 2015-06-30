namespace test
{
    partial class frmBaoCaoCongNo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.baoCaoCongNoSelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaSachMaintenanceDataSet = new test.QuanLyNhaSachMaintenanceDataSet();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblThang = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.baoCaoCongNoSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvBaoCaoCongNo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baoCaoCongNo_SelectAllByThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter();
            this.baoCaoCongNo_SelectThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter();
            this.quanLyNhaSachMaintenanceDataSet1 = new test.QuanLyNhaSachMaintenanceDataSet();
            this.baoCaoTonSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoTon_SelectThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter();
            this.baoCaoTonSelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoTon_SelectAllByThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter();
            this.BaoCaoCongNo_SelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectAllByThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectAllByThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // baoCaoCongNoSelectAllByThangBindingSource
            // 
            this.baoCaoCongNoSelectAllByThangBindingSource.DataMember = "BaoCaoCongNo_SelectAllByThang";
            this.baoCaoCongNoSelectAllByThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // quanLyNhaSachMaintenanceDataSet
            // 
            this.quanLyNhaSachMaintenanceDataSet.DataSetName = "QuanLyNhaSachMaintenanceDataSet";
            this.quanLyNhaSachMaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(466, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(91, 32);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(219, 19);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(78, 25);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng :";
            // 
            // cbThang
            // 
            this.cbThang.DataSource = this.baoCaoCongNoSelectThangBindingSource;
            this.cbThang.DisplayMember = "Thang";
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(294, 11);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(41, 33);
            this.cbThang.TabIndex = 2;
            this.cbThang.ValueMember = "Thang";
            // 
            // baoCaoCongNoSelectThangBindingSource
            // 
            this.baoCaoCongNoSelectThangBindingSource.DataMember = "BaoCaoCongNo_SelectThang";
            this.baoCaoCongNoSelectThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvBaoCaoCongNo);
            this.panel1.Location = new System.Drawing.Point(6, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 398);
            this.panel1.TabIndex = 3;
            // 
            // rpvBaoCaoCongNo
            // 
            this.rpvBaoCaoCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoCongNoDataSet";
            reportDataSource1.Value = this.BaoCaoCongNo_SelectAllByThangBindingSource;
            this.rpvBaoCaoCongNo.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCaoCongNo.LocalReport.ReportEmbeddedResource = "test.BaoCaoCongNo.rdlc";
            this.rpvBaoCaoCongNo.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCaoCongNo.Name = "rpvBaoCaoCongNo";
            this.rpvBaoCaoCongNo.Size = new System.Drawing.Size(778, 398);
            this.rpvBaoCaoCongNo.TabIndex = 0;
            // 
            // baoCaoCongNo_SelectAllByThangTableAdapter
            // 
            this.baoCaoCongNo_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoCongNo_SelectThangTableAdapter
            // 
            this.baoCaoCongNo_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyNhaSachMaintenanceDataSet1
            // 
            this.quanLyNhaSachMaintenanceDataSet1.DataSetName = "QuanLyNhaSachMaintenanceDataSet";
            this.quanLyNhaSachMaintenanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoTonSelectThangBindingSource
            // 
            this.baoCaoTonSelectThangBindingSource.DataMember = "BaoCaoTon_SelectThang";
            this.baoCaoTonSelectThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet1;
            // 
            // baoCaoTon_SelectThangTableAdapter
            // 
            this.baoCaoTon_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoTonSelectAllByThangBindingSource
            // 
            this.baoCaoTonSelectAllByThangBindingSource.DataMember = "BaoCaoTon_SelectAllByThang";
            this.baoCaoTonSelectAllByThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet1;
            // 
            // baoCaoTon_SelectAllByThangTableAdapter
            // 
            this.baoCaoTon_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoCongNo_SelectAllByThangBindingSource
            // 
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataMember = "BaoCaoCongNo_SelectAllByThang";
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "Báo Cáo Công Nợ";
            this.Load += new System.EventHandler(this.BaoCaoCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectAllByThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectAllByThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoCongNo;
        private QuanLyNhaSachMaintenanceDataSet quanLyNhaSachMaintenanceDataSet;
        private System.Windows.Forms.BindingSource baoCaoCongNoSelectAllByThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter baoCaoCongNo_SelectAllByThangTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoCongNoSelectThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter baoCaoCongNo_SelectThangTableAdapter;
        private QuanLyNhaSachMaintenanceDataSet quanLyNhaSachMaintenanceDataSet1;
        private System.Windows.Forms.BindingSource baoCaoTonSelectThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter baoCaoTon_SelectThangTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoTonSelectAllByThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter baoCaoTon_SelectAllByThangTableAdapter;
        private System.Windows.Forms.BindingSource BaoCaoCongNo_SelectAllByThangBindingSource;
    }
}