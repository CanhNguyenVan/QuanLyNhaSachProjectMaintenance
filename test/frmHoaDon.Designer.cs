namespace test
{
    partial class frmHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLap = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLamMoiHoaDon = new System.Windows.Forms.Button();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnSuaHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnLamMoiChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnThemChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnSuaChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnXoaChiTietHoaDon = new System.Windows.Forms.Button();
            this.MaChiTietHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDonInChiTietHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuongBan = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToOrderColumns = true;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaKhachHang,
            this.NgayLap});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(426, 541);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.SelectionChanged += new System.EventHandler(this.dgvHoaDon_SelectionChanged);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.MaxInputLength = 10;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Tên Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // NgayLap
            // 
            // 
            // 
            // 
            this.NgayLap.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgayLap.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgayLap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayLap.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgayLap.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayLap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayLap.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgayLap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayLap.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.NgayLap.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgayLap.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayLap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayLap.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgayLap.Name = "NgayLap";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToOrderColumns = true;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietHoaDon,
            this.MaHoaDonInChiTietHoaDon,
            this.MaSach,
            this.SoLuongBan});
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(445, 541);
            this.dgvChiTietHoaDon.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLamMoiHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.btnSuaHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.dgvHoaDon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnLamMoiChiTietHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.btnThemChiTietHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.btnSuaChiTietHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoaChiTietHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.dgvChiTietHoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(879, 543);
            this.splitContainer1.SplitterDistance = 428;
            this.splitContainer1.TabIndex = 11;
            // 
            // btnLamMoiHoaDon
            // 
            this.btnLamMoiHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiHoaDon.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoiHoaDon.Location = new System.Drawing.Point(106, 493);
            this.btnLamMoiHoaDon.Name = "btnLamMoiHoaDon";
            this.btnLamMoiHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoiHoaDon.TabIndex = 6;
            this.btnLamMoiHoaDon.UseVisualStyleBackColor = true;
            this.btnLamMoiHoaDon.Click += new System.EventHandler(this.btnLamMoiHoaDon_Click);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHoaDon.Image = global::test.Properties.Resources.add_icon1;
            this.btnThemHoaDon.Location = new System.Drawing.Point(187, 493);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnThemHoaDon.TabIndex = 7;
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // btnSuaHoaDon
            // 
            this.btnSuaHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaHoaDon.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSuaHoaDon.Location = new System.Drawing.Point(268, 493);
            this.btnSuaHoaDon.Name = "btnSuaHoaDon";
            this.btnSuaHoaDon.Size = new System.Drawing.Size(75, 44);
            this.btnSuaHoaDon.TabIndex = 8;
            this.btnSuaHoaDon.UseVisualStyleBackColor = true;
            this.btnSuaHoaDon.Click += new System.EventHandler(this.btnSuaHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHoaDon.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(349, 493);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnXoaHoaDon.TabIndex = 9;
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnLamMoiChiTietHoaDon
            // 
            this.btnLamMoiChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiChiTietHoaDon.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoiChiTietHoaDon.Location = new System.Drawing.Point(123, 493);
            this.btnLamMoiChiTietHoaDon.Name = "btnLamMoiChiTietHoaDon";
            this.btnLamMoiChiTietHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoiChiTietHoaDon.TabIndex = 11;
            this.btnLamMoiChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnLamMoiChiTietHoaDon.Click += new System.EventHandler(this.btnLamMoiChiTietHoaDon_Click);
            // 
            // btnThemChiTietHoaDon
            // 
            this.btnThemChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemChiTietHoaDon.Image = global::test.Properties.Resources.add_icon1;
            this.btnThemChiTietHoaDon.Location = new System.Drawing.Point(204, 493);
            this.btnThemChiTietHoaDon.Name = "btnThemChiTietHoaDon";
            this.btnThemChiTietHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnThemChiTietHoaDon.TabIndex = 12;
            this.btnThemChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnThemChiTietHoaDon.Click += new System.EventHandler(this.btnThemChiTietHoaDon_Click);
            // 
            // btnSuaChiTietHoaDon
            // 
            this.btnSuaChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaChiTietHoaDon.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSuaChiTietHoaDon.Location = new System.Drawing.Point(285, 493);
            this.btnSuaChiTietHoaDon.Name = "btnSuaChiTietHoaDon";
            this.btnSuaChiTietHoaDon.Size = new System.Drawing.Size(75, 44);
            this.btnSuaChiTietHoaDon.TabIndex = 13;
            this.btnSuaChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnSuaChiTietHoaDon.Click += new System.EventHandler(this.btnSuaChiTietHoaDon_Click);
            // 
            // btnXoaChiTietHoaDon
            // 
            this.btnXoaChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaChiTietHoaDon.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoaChiTietHoaDon.Location = new System.Drawing.Point(366, 493);
            this.btnXoaChiTietHoaDon.Name = "btnXoaChiTietHoaDon";
            this.btnXoaChiTietHoaDon.Size = new System.Drawing.Size(75, 45);
            this.btnXoaChiTietHoaDon.TabIndex = 14;
            this.btnXoaChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaChiTietHoaDon.Click += new System.EventHandler(this.btnXoaChiTietHoaDon_Click);
            // 
            // MaChiTietHoaDon
            // 
            this.MaChiTietHoaDon.DataPropertyName = "MaChiTietHoaDon";
            this.MaChiTietHoaDon.HeaderText = "Mã Chi Tiết Hóa Đơn";
            this.MaChiTietHoaDon.MaxInputLength = 10;
            this.MaChiTietHoaDon.Name = "MaChiTietHoaDon";
            // 
            // MaHoaDonInChiTietHoaDon
            // 
            this.MaHoaDonInChiTietHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDonInChiTietHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDonInChiTietHoaDon.Name = "MaHoaDonInChiTietHoaDon";
            this.MaHoaDonInChiTietHoaDon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Tên Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SoLuongBan
            // 
            // 
            // 
            // 
            this.SoLuongBan.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.SoLuongBan.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.SoLuongBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoLuongBan.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            this.SoLuongBan.HeaderText = "Số Lượng Bán";
            this.SoLuongBan.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoLuongBan.Name = "SoLuongBan";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 543);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLamMoiHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnSuaHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnLamMoiChiTietHoaDon;
        private System.Windows.Forms.Button btnThemChiTietHoaDon;
        private System.Windows.Forms.Button btnSuaChiTietHoaDon;
        private System.Windows.Forms.Button btnXoaChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhachHang;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDonInChiTietHoaDon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongBan;
    }
}