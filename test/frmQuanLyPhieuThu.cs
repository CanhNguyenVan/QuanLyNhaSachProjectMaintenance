﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace test
{
    public partial class frmQuanLyPhieuThu : Form
    {
        private PhieuThuTienBLL _phieuThuTienBll = new PhieuThuTienBLL();
        
        private KhachHangBLL _khachHangBll = new KhachHangBLL();

        public frmQuanLyPhieuThu()
        {
            InitializeComponent();

            Load += frmQuanLyPhieuThu_Load;
        }

        void frmQuanLyPhieuThu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       
        private void LoadData()
        {
            dgvPhieuThu.DataSource = _phieuThuTienBll.SelectAll();

            (dgvPhieuThu.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).DataSource = _khachHangBll.SelectAll();
            (dgvPhieuThu.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (dgvPhieuThu.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).ValueMember = "MaKhachHang";  
        } 
        
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int index = dgvPhieuThu.CurrentCell.RowIndex;

            string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            phieuThuTienDto.SoTienThu = soTienThu;
            phieuThuTienDto.MaKhachHang = maKhachHang;
            phieuThuTienDto.NgayThu = ngayThu;

            if (_phieuThuTienBll.InsertPhieuThuTien(phieuThuTienDto) == 1)
            {
                MessageBox.Show("Thêm phiếu thu tiền thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu thu!", "Lỗi!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = dgvPhieuThu.CurrentCell.RowIndex;

            string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            phieuThuTienDto.SoTienThu = soTienThu;
            phieuThuTienDto.MaKhachHang = maKhachHang;
            phieuThuTienDto.NgayThu = ngayThu;

            if (_phieuThuTienBll.UpdatePhieuThuTien(phieuThuTienDto) == 1)
            {
                MessageBox.Show("Cập nhật phiếu thu tiền thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu thu không tồn tại!", "Lỗi!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dgvPhieuThu.CurrentCell.RowIndex;

            string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            phieuThuTienDto.SoTienThu = soTienThu;
            phieuThuTienDto.MaKhachHang = maKhachHang;
            phieuThuTienDto.NgayThu = ngayThu;

            if (_phieuThuTienBll.DeleteByMaPhieuThuTien(phieuThuTienDto) == 1)
            {
                MessageBox.Show("Xóa phiếu thu tiền thành công!");

                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra hoặc mã phiếu thu không tồn tại!", "Lỗi!");
            }
        }

    }
}