using System;
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
    public partial class frmQuanLyKhachHang : Form
    {
        private KhachHangBLL _khachHangBll = new KhachHangBLL();

        private PhieuThuTienBLL _phieuThuTienBll = new PhieuThuTienBLL();

        private HoaDonBLL _hoaDonBll = new HoaDonBLL();

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            Load += frmQuanLyKhachHang_Load;
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvKhachHang.DataSource = _khachHangBll.SelectAll();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhachHang.CurrentCell.RowIndex;

                string maKhachHang = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
                string hoTen = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
                string diaChi = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
                int dienThoai = Int32.Parse(dgvKhachHang.Rows[index].Cells[3].Value.ToString());
                string email = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
                float soTienNo = float.Parse(dgvKhachHang.Rows[index].Cells[5].Value.ToString());

                KhachHangDTO khachHangDto = new KhachHangDTO();
                khachHangDto.MaKhachHang = maKhachHang;
                khachHangDto.HoTen = hoTen;
                khachHangDto.DiaChi = diaChi;
                khachHangDto.DienThoai = dienThoai;
                khachHangDto.Email = email;
                khachHangDto.SoTienNo = soTienNo;

                if (_khachHangBll.InsertKhachHang(khachHangDto) != 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã khách hàng!", "Lỗi!");
                }         
            }
            catch (Exception)
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhachHang.CurrentCell.RowIndex;

                string maKhachHang = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
                string hoTen = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
                string diaChi = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
                int dienThoai = Int32.Parse(dgvKhachHang.Rows[index].Cells[3].Value.ToString());
                string email = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
                float soTienNo = float.Parse(dgvKhachHang.Rows[index].Cells[5].Value.ToString());

                KhachHangDTO khachHangDto = new KhachHangDTO();
                khachHangDto.MaKhachHang = maKhachHang;
                khachHangDto.HoTen = hoTen;
                khachHangDto.DiaChi = diaChi;
                khachHangDto.DienThoai = dienThoai;
                khachHangDto.Email = email;
                khachHangDto.SoTienNo = soTienNo;

                if (_khachHangBll.UpdateKhachHang(khachHangDto) != 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã khách hàng!", "Lỗi!");
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhachHang.CurrentCell.RowIndex;

                string maKhachHang = dgvKhachHang.Rows[index].Cells[0].Value.ToString();
                string hoTen = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
                string diaChi = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
                int dienThoai = Int32.Parse(dgvKhachHang.Rows[index].Cells[3].Value.ToString());
                string email = dgvKhachHang.Rows[index].Cells[4].Value.ToString();
                float soTienNo = float.Parse(dgvKhachHang.Rows[index].Cells[5].Value.ToString());

                KhachHangDTO khachHangDto = new KhachHangDTO();
                khachHangDto.MaKhachHang = maKhachHang;
                khachHangDto.HoTen = hoTen;
                khachHangDto.DiaChi = diaChi;
                khachHangDto.DienThoai = dienThoai;
                khachHangDto.Email = email;
                khachHangDto.SoTienNo = soTienNo;

                if (_khachHangBll.DeleteByMaKhachHang(khachHangDto) != 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi : nhập sai hoặc không tồn tại mã khách hàng!", "Lỗi!");
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
