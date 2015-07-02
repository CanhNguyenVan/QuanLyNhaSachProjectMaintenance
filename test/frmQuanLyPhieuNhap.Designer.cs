namespace test
{
    partial class frmQuanLyPhieuNhap
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
            this.dgvQuanLyPhieuNhap = new System.Windows.Forms.DataGridView();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuanLyPhieuNhap
            // 
            this.dgvQuanLyPhieuNhap.AllowUserToOrderColumns = true;
            this.dgvQuanLyPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.NgayNhap});
            this.dgvQuanLyPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLyPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvQuanLyPhieuNhap.Name = "dgvQuanLyPhieuNhap";
            this.dgvQuanLyPhieuNhap.Size = new System.Drawing.Size(529, 336);
            this.dgvQuanLyPhieuNhap.TabIndex = 5;
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // NgayNhap
            // 
            // 
            // 
            // 
            this.NgayNhap.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgayNhap.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgayNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayNhap.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgayNhap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayNhap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayNhap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgayNhap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayNhap.MonthCalendar.DisplayMonth = new System.DateTime(2015, 7, 1, 0, 0, 0, 0);
            this.NgayNhap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgayNhap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayNhap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayNhap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgayNhap.Name = "NgayNhap";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(197, 279);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = global::test.Properties.Resources.add_icon1;
            this.btnThem.Location = new System.Drawing.Point(278, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSua.Location = new System.Drawing.Point(359, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 16;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoa.Location = new System.Drawing.Point(440, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 336);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvQuanLyPhieuNhap);
            this.Name = "frmQuanLyPhieuNhap";
            this.Text = "frmQuanLyPhieuNhap";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayNhap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}