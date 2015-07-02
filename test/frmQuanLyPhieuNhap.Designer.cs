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
            this.NgayNhap = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuanLyPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi1 = new System.Windows.Forms.Button();
            this.btnThem1 = new System.Windows.Forms.Button();
            this.btnSua1 = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.MaChiTietPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuNhapInChiTietPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuongNhap = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.DonGiaNhap = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.NgayNhap.FillWeight = 50F;
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
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhap.FillWeight = 50F;
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
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
            this.dgvQuanLyPhieuNhap.Size = new System.Drawing.Size(545, 380);
            this.dgvQuanLyPhieuNhap.TabIndex = 5;
            this.dgvQuanLyPhieuNhap.SelectionChanged += new System.EventHandler(this.dgvQuanLyPhieuNhap_SelectionChanged);
            // 
            // dgvChiTietPhieuNhap
            // 
            this.dgvChiTietPhieuNhap.AllowUserToOrderColumns = true;
            this.dgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietPhieuNhap,
            this.MaPhieuNhapInChiTietPhieuNhap,
            this.MaSach,
            this.SoLuongNhap,
            this.DonGiaNhap});
            this.dgvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            this.dgvChiTietPhieuNhap.Size = new System.Drawing.Size(515, 380);
            this.dgvChiTietPhieuNhap.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLamMoi);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.dgvQuanLyPhieuNhap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLamMoi1);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem1);
            this.splitContainer1.Panel2.Controls.Add(this.btnSua1);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvChiTietPhieuNhap);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 380);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 23;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(216, 322);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = global::test.Properties.Resources.add_icon1;
            this.btnThem.Location = new System.Drawing.Point(297, 322);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 19;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSua.Location = new System.Drawing.Point(378, 322);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 20;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoa.Location = new System.Drawing.Point(459, 322);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnLamMoi1
            // 
            this.btnLamMoi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi1.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoi1.Location = new System.Drawing.Point(192, 322);
            this.btnLamMoi1.Name = "btnLamMoi1";
            this.btnLamMoi1.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoi1.TabIndex = 23;
            this.btnLamMoi1.UseVisualStyleBackColor = true;
            this.btnLamMoi1.Click += new System.EventHandler(this.btnLamMoi1_Click_1);
            // 
            // btnThem1
            // 
            this.btnThem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem1.Image = global::test.Properties.Resources.add_icon1;
            this.btnThem1.Location = new System.Drawing.Point(273, 321);
            this.btnThem1.Name = "btnThem1";
            this.btnThem1.Size = new System.Drawing.Size(75, 45);
            this.btnThem1.TabIndex = 24;
            this.btnThem1.UseVisualStyleBackColor = true;
            this.btnThem1.Click += new System.EventHandler(this.btnThem1_Click);
            // 
            // btnSua1
            // 
            this.btnSua1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua1.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSua1.Location = new System.Drawing.Point(354, 322);
            this.btnSua1.Name = "btnSua1";
            this.btnSua1.Size = new System.Drawing.Size(75, 44);
            this.btnSua1.TabIndex = 25;
            this.btnSua1.UseVisualStyleBackColor = true;
            this.btnSua1.Click += new System.EventHandler(this.btnSua1_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa1.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoa1.Location = new System.Drawing.Point(435, 322);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 45);
            this.btnXoa1.TabIndex = 26;
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // MaChiTietPhieuNhap
            // 
            this.MaChiTietPhieuNhap.DataPropertyName = "MaChiTietPhieuNhap";
            this.MaChiTietPhieuNhap.HeaderText = "Mã Chi Tiết Phiếu Nhập";
            this.MaChiTietPhieuNhap.Name = "MaChiTietPhieuNhap";
            // 
            // MaPhieuNhapInChiTietPhieuNhap
            // 
            this.MaPhieuNhapInChiTietPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.MaPhieuNhapInChiTietPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.MaPhieuNhapInChiTietPhieuNhap.Name = "MaPhieuNhapInChiTietPhieuNhap";
            this.MaPhieuNhapInChiTietPhieuNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Tên Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongNhap
            // 
            // 
            // 
            // 
            this.SoLuongNhap.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.SoLuongNhap.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.SoLuongNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoLuongNhap.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.SoLuongNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DonGiaNhap
            // 
            // 
            // 
            // 
            this.DonGiaNhap.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DonGiaNhap.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.DonGiaNhap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGiaNhap.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.Increment = 1D;
            this.DonGiaNhap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // frmQuanLyPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 380);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmQuanLyPhieuNhap";
            this.Text = "frmQuanLyPhieuNhap";
            this.Load += new System.EventHandler(this.frmQuanLyPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuNhap)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridView dgvQuanLyPhieuNhap;
        private System.Windows.Forms.DataGridView dgvChiTietPhieuNhap;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi1;
        private System.Windows.Forms.Button btnThem1;
        private System.Windows.Forms.Button btnSua1;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhapInChiTietPhieuNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongNhap;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn DonGiaNhap;
    }
}