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
            this.BaoCaoCongNo_SelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhaSachMaintenanceDataSet = new test.QuanLyNhaSachMaintenanceDataSet();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.baoCaoCongNoSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblThang = new System.Windows.Forms.Label();
            this.baoCaoCongNo_SelectThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter();
            this.pnBCCN = new System.Windows.Forms.Panel();
            this.rpvBCCN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCaoCongNo_SelectAllByThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).BeginInit();
            this.pnBCCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoCaoCongNo_SelectAllByThangBindingSource
            // 
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataMember = "BaoCaoCongNo_SelectAllByThang";
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // quanLyNhaSachMaintenanceDataSet
            // 
            this.quanLyNhaSachMaintenanceDataSet.DataSetName = "QuanLyNhaSachMaintenanceDataSet";
            this.quanLyNhaSachMaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(394, 10);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 30);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cmbThang
            // 
            this.cmbThang.DataSource = this.baoCaoCongNoSelectThangBindingSource;
            this.cmbThang.DisplayMember = "Thang";
            this.cmbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(286, 13);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(61, 27);
            this.cmbThang.TabIndex = 5;
            this.cmbThang.ValueMember = "Thang";
            // 
            // baoCaoCongNoSelectThangBindingSource
            // 
            this.baoCaoCongNoSelectThangBindingSource.DataMember = "BaoCaoCongNo_SelectThang";
            this.baoCaoCongNoSelectThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(207, 14);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(73, 22);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng :";
            // 
            // baoCaoCongNo_SelectThangTableAdapter
            // 
            this.baoCaoCongNo_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // pnBCCN
            // 
            this.pnBCCN.Controls.Add(this.rpvBCCN);
            this.pnBCCN.Location = new System.Drawing.Point(12, 46);
            this.pnBCCN.Name = "pnBCCN";
            this.pnBCCN.Size = new System.Drawing.Size(677, 360);
            this.pnBCCN.TabIndex = 7;
            // 
            // rpvBCCN
            // 
            this.rpvBCCN.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoCongNoDataSet";
            reportDataSource1.Value = this.BaoCaoCongNo_SelectAllByThangBindingSource;
            this.rpvBCCN.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBCCN.LocalReport.ReportEmbeddedResource = "test.BaoCaoCongNo.rdlc";
            this.rpvBCCN.Location = new System.Drawing.Point(0, 0);
            this.rpvBCCN.Name = "rpvBCCN";
            this.rpvBCCN.Size = new System.Drawing.Size(677, 360);
            this.rpvBCCN.TabIndex = 0;
            // 
            // BaoCaoCongNo_SelectAllByThangTableAdapter
            // 
            this.BaoCaoCongNo_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.pnBCCN);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.lblThang);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "Báo Cáo Công Nợ";
            this.Load += new System.EventHandler(this.frmBaoCaoCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).EndInit();
            this.pnBCCN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label lblThang;
        private QuanLyNhaSachMaintenanceDataSet quanLyNhaSachMaintenanceDataSet;
        private System.Windows.Forms.BindingSource baoCaoCongNoSelectThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter baoCaoCongNo_SelectThangTableAdapter;
        private System.Windows.Forms.Panel pnBCCN;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCCN;
        private System.Windows.Forms.BindingSource BaoCaoCongNo_SelectAllByThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter BaoCaoCongNo_SelectAllByThangTableAdapter;
    }
}