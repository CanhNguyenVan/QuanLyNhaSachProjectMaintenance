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
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvBaoCaoTon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyNhaSachMaintenanceDataSet = new test.QuanLyNhaSachMaintenanceDataSet();
            this.baoCaoTonSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoTon_SelectThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter();
            this.BaoCaoTon_SelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoTon_SelectAllByThangTableAdapter = new test.QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThang
            // 
            this.cbThang.DataSource = this.baoCaoTonSelectThangBindingSource;
            this.cbThang.DisplayMember = "Thang";
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(274, 13);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(41, 33);
            this.cbThang.TabIndex = 5;
            this.cbThang.ValueMember = "Thang";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(199, 21);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(78, 25);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng :";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(446, 14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(91, 32);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvBaoCaoTon);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 384);
            this.panel1.TabIndex = 6;
            // 
            // rpvBaoCaoTon
            // 
            this.rpvBaoCaoTon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "BaoCaoTonDataSet";
            reportDataSource2.Value = this.BaoCaoTon_SelectAllByThangBindingSource;
            this.rpvBaoCaoTon.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvBaoCaoTon.LocalReport.ReportEmbeddedResource = "test.BaoCaoTon.rdlc";
            this.rpvBaoCaoTon.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCaoTon.Name = "rpvBaoCaoTon";
            this.rpvBaoCaoTon.Size = new System.Drawing.Size(733, 384);
            this.rpvBaoCaoTon.TabIndex = 0;
            // 
            // quanLyNhaSachMaintenanceDataSet
            // 
            this.quanLyNhaSachMaintenanceDataSet.DataSetName = "QuanLyNhaSachMaintenanceDataSet";
            this.quanLyNhaSachMaintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoTonSelectThangBindingSource
            // 
            this.baoCaoTonSelectThangBindingSource.DataMember = "BaoCaoTon_SelectThang";
            this.baoCaoTonSelectThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // baoCaoTon_SelectThangTableAdapter
            // 
            this.baoCaoTon_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoTon_SelectAllByThangBindingSource
            // 
            this.BaoCaoTon_SelectAllByThangBindingSource.DataMember = "BaoCaoTon_SelectAllByThang";
            this.BaoCaoTon_SelectAllByThangBindingSource.DataSource = this.quanLyNhaSachMaintenanceDataSet;
            // 
            // BaoCaoTon_SelectAllByThangTableAdapter
            // 
            this.BaoCaoTon_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmBaoCaoTon";
            this.Text = "Báo Cáo Tồn";
            this.Load += new System.EventHandler(this.frmBaoCaoTon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachMaintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoTon;
        private QuanLyNhaSachMaintenanceDataSet quanLyNhaSachMaintenanceDataSet;
        private System.Windows.Forms.BindingSource baoCaoTonSelectThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter baoCaoTon_SelectThangTableAdapter;
        private System.Windows.Forms.BindingSource BaoCaoTon_SelectAllByThangBindingSource;
        private QuanLyNhaSachMaintenanceDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter BaoCaoTon_SelectAllByThangTableAdapter;
    }
}