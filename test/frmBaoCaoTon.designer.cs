namespace test
{
    partial class frmBaoCaoTon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnBCT = new System.Windows.Forms.Panel();
            this.lblThang = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.rpvBCT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyNhaSachMaintenanceDataSet = new test.QuanLyNhaSachMaintenanceDataSet();
            this.BaoCaoTon_SelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoTon_SelectAllByThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter();
            this.baoCaoTonSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoTon_SelectThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter();
            this.pnBCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhaSachMaintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBCT
            // 
            this.pnBCT.Controls.Add(this.rpvBCT);
            this.pnBCT.Location = new System.Drawing.Point(12, 58);
            this.pnBCT.Name = "pnBCT";
            this.pnBCT.Size = new System.Drawing.Size(679, 393);
            this.pnBCT.TabIndex = 0;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(218, 25);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(73, 22);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng :";
            // 
            // cmbThang
            // 
            this.cmbThang.DataSource = this.baoCaoTonSelectThangBindingSource;
            this.cmbThang.DisplayMember = "Thang";
            this.cmbThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(297, 24);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(61, 27);
            this.cmbThang.TabIndex = 2;
            this.cmbThang.ValueMember = "Thang";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(405, 21);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 30);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // rpvBCT
            // 
            this.rpvBCT.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoTonDataSet";
            reportDataSource2.Value = this.BaoCaoTon_SelectAllByThangBindingSource;
            this.rpvBCT.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvBCT.LocalReport.ReportEmbeddedResource = "test.BaoCaoTon.rdlc";
            this.rpvBCT.Location = new System.Drawing.Point(0, 0);
            this.rpvBCT.Name = "rpvBCT";
            this.rpvBCT.Size = new System.Drawing.Size(679, 393);
            this.rpvBCT.TabIndex = 0;
            // 
            // QuanLyNhaSachMaintenanceDataSet
            // 
            this.QuanLyNhaSachMaintenanceDataSet.DataSetName = "QuanLyNhaSachMaintenanceDataSet";
            this.QuanLyNhaSachMaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCaoTon_SelectAllByThangBindingSource
            // 
            this.BaoCaoTon_SelectAllByThangBindingSource.DataMember = "BaoCaoTon_SelectAllByThang";
            this.BaoCaoTon_SelectAllByThangBindingSource.DataSource = this.QuanLyNhaSachMaintenanceDataSet;
            // 
            // BaoCaoTon_SelectAllByThangTableAdapter
            // 
            this.BaoCaoTon_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // baoCaoTonSelectThangBindingSource
            // 
            this.baoCaoTonSelectThangBindingSource.DataMember = "BaoCaoTon_SelectThang";
            this.baoCaoTonSelectThangBindingSource.DataSource = this.QuanLyNhaSachMaintenanceDataSet;
            // 
            // baoCaoTon_SelectThangTableAdapter
            // 
            this.baoCaoTon_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 455);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cmbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.pnBCT);
            this.Name = "frmBaoCaoTon";
            this.Text = "Báo Cáo Tồn";
            this.Load += new System.EventHandler(this.frmBaoCaoTon_Load);
            this.pnBCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhaSachMaintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBCT;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Button btnThongKe;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCT;
        private System.Windows.Forms.BindingSource BaoCaoTon_SelectAllByThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSet QuanLyNhaSachMaintenanceDataSet;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter BaoCaoTon_SelectAllByThangTableAdapter;
        private System.Windows.Forms.BindingSource baoCaoTonSelectThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter baoCaoTon_SelectThangTableAdapter;
    }
}