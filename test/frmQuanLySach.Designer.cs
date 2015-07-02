namespace test
{
    partial class frmQuanLySach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSanXuat = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.SoLuongTon = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.DonGia = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToOrderColumns = true;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TenTacGia,
            this.NamSanXuat,
            this.SoLuongTon,
            this.DonGia});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(851, 395);
            this.dgvSach.TabIndex = 4;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 80F;
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 120F;
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.FillWeight = 120F;
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TacGia";
            this.TenTacGia.FillWeight = 120F;
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // NamSanXuat
            // 
            // 
            // 
            // 
            this.NamSanXuat.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NamSanXuat.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.NamSanXuat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NamSanXuat.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NamSanXuat.DataPropertyName = "NamXuatBan";
            this.NamSanXuat.FillWeight = 120F;
            this.NamSanXuat.HeaderText = "Năm Sản Xuất";
            this.NamSanXuat.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.NamSanXuat.Name = "NamSanXuat";
            this.NamSanXuat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoLuongTon
            // 
            // 
            // 
            // 
            this.SoLuongTon.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.SoLuongTon.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.SoLuongTon.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SoLuongTon.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.FillWeight = 120F;
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DonGia
            // 
            // 
            // 
            // 
            this.DonGia.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DonGia.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.DonGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGia.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.DonGia.DataPropertyName = "DonGiaBan";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Increment = 1D;
            this.DonGia.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.DonGia.Name = "DonGia";
            this.DonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Image = global::test.Properties.Resources.refresh;
            this.btnLamMoi.Location = new System.Drawing.Point(518, 338);
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
            this.btnThem.Location = new System.Drawing.Point(599, 338);
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
            this.btnSua.Location = new System.Drawing.Point(680, 338);
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
            this.btnXoa.Location = new System.Drawing.Point(761, 338);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 45);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 395);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvSach);
            this.Name = "frmQuanLySach";
            this.Text = "frmQuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn NamSanXuat;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongTon;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn DonGia;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}