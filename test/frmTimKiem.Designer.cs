namespace test
{
    partial class frmTimKiem
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.SoLuongTon = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.DonGiaBan = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.cbxLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(15, 5);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(380, 20);
            this.txtQuery.TabIndex = 6;
            this.txtQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSach_KeyDown);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TheLoai,
            this.TacGia,
            this.NamXuatBan,
            this.SoLuongTon,
            this.DonGiaBan});
            this.dgvTimKiem.Location = new System.Drawing.Point(15, 35);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(828, 390);
            this.dgvTimKiem.TabIndex = 8;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // TheLoai
            // 
            this.TheLoai.DataPropertyName = "TheLoai";
            this.TheLoai.HeaderText = "Thể Loại";
            this.TheLoai.Name = "TheLoai";
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            // 
            // NamXuatBan
            // 
            // 
            // 
            // 
            this.NamXuatBan.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.NamXuatBan.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.NamXuatBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NamXuatBan.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.NamXuatBan.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.NamXuatBan.Name = "NamXuatBan";
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
            this.SoLuongTon.HeaderText = "Số Lượng Tồn";
            this.SoLuongTon.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.SoLuongTon.Name = "SoLuongTon";
            // 
            // DonGiaBan
            // 
            // 
            // 
            // 
            this.DonGiaBan.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.DonGiaBan.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.DonGiaBan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DonGiaBan.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.Increment = 1D;
            this.DonGiaBan.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // cbxLoaiTimKiem
            // 
            this.cbxLoaiTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiTimKiem.FormattingEnabled = true;
            this.cbxLoaiTimKiem.Items.AddRange(new object[] {
            "Mã Sách",
            "Tên Sách",
            "Thể Loại",
            "Tác Giả"});
            this.cbxLoaiTimKiem.Location = new System.Drawing.Point(722, 5);
            this.cbxLoaiTimKiem.Name = "cbxLoaiTimKiem";
            this.cbxLoaiTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cbxLoaiTimKiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(415, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 437);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLoaiTimKiem);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.txtQuery);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.ComboBox cbxLoaiTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn NamXuatBan;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn SoLuongTon;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn DonGiaBan;
        private System.Windows.Forms.Button btnTimKiem;
    }
}