namespace test
{
    partial class frmQuanLyPhieuThu
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
            this.dgvPhieuThu = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.MaPhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayThu = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuThu
            // 
            this.dgvPhieuThu.AllowUserToOrderColumns = true;
            this.dgvPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuThu,
            this.SoTienThu,
            this.MaKhachHang,
            this.NgayThu});
            this.dgvPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieuThu.Name = "dgvPhieuThu";
            this.dgvPhieuThu.Size = new System.Drawing.Size(684, 465);
            this.dgvPhieuThu.TabIndex = 2;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(356, 412);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 45);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = global::test.Properties.Resources.add_icon1;
            this.btnThem.Location = new System.Drawing.Point(437, 412);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = global::test.Properties.Resources.edit_validated_icon;
            this.btnSua.Location = new System.Drawing.Point(518, 412);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 4;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = global::test.Properties.Resources.delete_icon;
            this.btnXoa.Location = new System.Drawing.Point(599, 412);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // MaPhieuThu
            // 
            this.MaPhieuThu.DataPropertyName = "MaPhieuThuTien";
            this.MaPhieuThu.HeaderText = "Mã Phiếu Thu";
            this.MaPhieuThu.Name = "MaPhieuThu";
            // 
            // SoTienThu
            // 
            // 
            // 
            // 
            this.SoTienThu.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.SoTienThu.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.SoTienThu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoTienThu.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.SoTienThu.DataPropertyName = "SoTienThu";
            this.SoTienThu.HeaderText = "Số Tiền Thu";
            this.SoTienThu.Increment = 1D;
            this.SoTienThu.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Khách Hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // NgayThu
            // 
            // 
            // 
            // 
            this.NgayThu.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NgayThu.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.NgayThu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThu.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NgayThu.DataPropertyName = "NgayThu";
            this.NgayThu.HeaderText = "Ngày Thu";
            this.NgayThu.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.NgayThu.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayThu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThu.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.NgayThu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThu.MonthCalendar.DisplayMonth = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.NgayThu.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.NgayThu.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.NgayThu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NgayThu.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.NgayThu.Name = "NgayThu";
            // 
            // frmQuanLyPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 465);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvPhieuThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyPhieuThu";
            this.Text = "Quản Lý Phiếu Thu Tiền";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvPhieuThu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuThu;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn SoTienThu;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKhachHang;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn NgayThu;
    }
}