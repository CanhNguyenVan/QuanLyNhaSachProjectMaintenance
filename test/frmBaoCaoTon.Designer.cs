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
            this.pnBCT = new System.Windows.Forms.Panel();
            this.reportViewerBCT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.quanLyNhaSachDataSet = new test.QuanLyNhaSachDataSet();
            this.baoCaoTonSelectThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baoCaoTon_SelectThangTableAdapter = new test.QuanLyNhaSachDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter();
            this.BaoCaoTon_SelectAllByThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoTon_SelectAllByThangTableAdapter = new test.QuanLyNhaSachDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter();
            this.pnBCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbThang
            // 
            this.cbThang.DataSource = this.baoCaoTonSelectThangBindingSource;
            this.cbThang.DisplayMember = "Thang";
            this.cbThang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(301, 14);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(49, 31);
            this.cbThang.TabIndex = 5;
            this.cbThang.ValueMember = "Thang";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(220, 17);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(75, 23);
            this.lblThang.TabIndex = 4;
            this.lblThang.Text = "Tháng :";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(451, 14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(107, 31);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // pnBCT
            // 
            this.pnBCT.Controls.Add(this.reportViewerBCT);
            this.pnBCT.Location = new System.Drawing.Point(12, 68);
            this.pnBCT.Name = "pnBCT";
            this.pnBCT.Size = new System.Drawing.Size(731, 393);
            this.pnBCT.TabIndex = 6;
            // 
            // reportViewerBCT
            // 
            this.reportViewerBCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerBCT.DocumentMapWidth = 55;
            reportDataSource2.Name = "BaoCaoTonDataSet";
            reportDataSource2.Value = this.BaoCaoTon_SelectAllByThangBindingSource;
            this.reportViewerBCT.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerBCT.LocalReport.ReportEmbeddedResource = "test.BaoCaoTon.rdlc";
            this.reportViewerBCT.Location = new System.Drawing.Point(0, 0);
            this.reportViewerBCT.Name = "reportViewerBCT";
            this.reportViewerBCT.Size = new System.Drawing.Size(731, 393);
            this.reportViewerBCT.TabIndex = 0;
            // 
            // quanLyNhaSachDataSet
            // 
            this.quanLyNhaSachDataSet.DataSetName = "QuanLyNhaSachDataSet";
            this.quanLyNhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoTonSelectThangBindingSource
            // 
            this.baoCaoTonSelectThangBindingSource.DataMember = "BaoCaoTon_SelectThang";
            this.baoCaoTonSelectThangBindingSource.DataSource = this.quanLyNhaSachDataSet;
            // 
            // baoCaoTon_SelectThangTableAdapter
            // 
            this.baoCaoTon_SelectThangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoTon_SelectAllByThangBindingSource
            // 
            this.BaoCaoTon_SelectAllByThangBindingSource.DataMember = "BaoCaoTon_SelectAllByThang";
            this.BaoCaoTon_SelectAllByThangBindingSource.DataSource = this.quanLyNhaSachDataSet;
            // 
            // BaoCaoTon_SelectAllByThangTableAdapter
            // 
            this.BaoCaoTon_SelectAllByThangTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 463);
            this.Controls.Add(this.pnBCT);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnThongKe);
            this.Name = "frmBaoCaoTon";
            this.Text = "BaoCaoTon";
            this.Load += new System.EventHandler(this.frmBaoCaoTon_Load);
            this.pnBCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhaSachDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baoCaoTonSelectThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoTon_SelectAllByThangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnBCT;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBCT;
        private QuanLyNhaSachDataSet quanLyNhaSachDataSet;
        private System.Windows.Forms.BindingSource baoCaoTonSelectThangBindingSource;
        private QuanLyNhaSachDataSetTableAdapters.BaoCaoTon_SelectThangTableAdapter baoCaoTon_SelectThangTableAdapter;
        private System.Windows.Forms.BindingSource BaoCaoTon_SelectAllByThangBindingSource;
        private QuanLyNhaSachDataSetTableAdapters.BaoCaoTon_SelectAllByThangTableAdapter BaoCaoTon_SelectAllByThangTableAdapter;
    }
}