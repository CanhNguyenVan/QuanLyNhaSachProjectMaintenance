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
            this.quanLyNhaSachDataSet = new test.QuanLyNhaSachDataSet();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblThang = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.baoCaoCongNoSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnBCCN = new System.Windows.Forms.Panel();
            this.reportViewerBCCN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.baoCaoCongNo_SelectThangTableAdapter = new test.QuanLyNhaSachDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter();
            this.BaoCaoCongNo_SelectAllByThangTableAdapter = new test.QuanLyNhaSachDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).BeginInit();
            this.pnBCCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoCaoCongNo_SelectAllByThangBindingSource
            // 
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataMember = "BaoCaoCongNo_SelectAllByThang";
            this.BaoCaoCongNo_SelectAllByThangBindingSource.DataSource = this.quanLyNhaSachDataSet;
            // 
            // quanLyNhaSachDataSet
            // 
            this.quanLyNhaSachDataSet.DataSetName = "QuanLyNhaSachDataSet";
            this.quanLyNhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(411, 13);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(106, 31);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(180, 16);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(75, 23);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng :";
            // 
            // cbThang
            // 
            this.cbThang.DataSource = this.baoCaoCongNoSelectThangBindingSource;
            this.cbThang.DisplayMember = "Thang";
            this.cbThang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(261, 13);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(49, 31);
            this.cbThang.TabIndex = 2;
            this.cbThang.ValueMember = "Thang";
            // 
            // baoCaoCongNoSelectThangBindingSource
            // 
            this.baoCaoCongNoSelectThangBindingSource.DataMember = "BaoCaoCongNo_SelectThang";
            this.baoCaoCongNoSelectThangBindingSource.DataSource = this.quanLyNhaSachDataSet;
            // 
            // pnBCCN
            // 
            this.pnBCCN.Controls.Add(this.reportViewerBCCN);
            this.pnBCCN.Location = new System.Drawing.Point(12, 63);
            this.pnBCCN.Name = "pnBCCN";
            this.pnBCCN.Size = new System.Drawing.Size(700, 366);
            this.pnBCCN.TabIndex = 3;
            // 
            // reportViewerBCCN
            // 
            this.reportViewerBCCN.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "BaoCaoCongNoDataSet";
            reportDataSource1.Value = this.BaoCaoCongNo_SelectAllByThangBindingSource;
            this.reportViewerBCCN.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBCCN.LocalReport.ReportEmbeddedResource = "test.BaoCaoCongNo.rdlc";
            this.reportViewerBCCN.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBCCN.Name = "reportViewerBCCN";
            this.reportViewerBCCN.Size = new System.Drawing.Size(700, 366);
            this.reportViewerBCCN.TabIndex = 0;
            // 
            // baoCaoCongNo_SelectThangTableAdapter
            // 
            this.baoCaoCongNo_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoCongNo_SelectAllByThangTableAdapter
            // 
            this.BaoCaoCongNo_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 438);
            this.Controls.Add(this.pnBCCN);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmBaoCaoCongNo";
            this.Text = "frmBaoCaoCongNo";
            this.Load += new System.EventHandler(this.frmBaoCaoCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoCongNo_SelectAllByThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoCongNoSelectThangBindingSource)).EndInit();
            this.pnBCCN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Panel pnBCCN;
        private QuanLyNhaSachDataSet quanLyNhaSachDataSet;
        private System.Windows.Forms.BindingSource baoCaoCongNoSelectThangBindingSource;
        private QuanLyNhaSachDataSetTableAdapters.BaoCaoCongNo_SelectThangTableAdapter baoCaoCongNo_SelectThangTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBCCN;
        private System.Windows.Forms.BindingSource BaoCaoCongNo_SelectAllByThangBindingSource;
        private QuanLyNhaSachDataSetTableAdapters.BaoCaoCongNo_SelectAllByThangTableAdapter BaoCaoCongNo_SelectAllByThangTableAdapter;
    }
}