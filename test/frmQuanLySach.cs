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
    public partial class frmQuanLySach : Form
    {
        private SachBLL _sachBll = new SachBLL();

        private ChiTietPhieuNhapBLL _chiTietPhieuNhapBll = new ChiTietPhieuNhapBLL();

        private ChiTietHoaDonBLL _chiTietHoaDonBll = new ChiTietHoaDonBLL(); 

        public frmQuanLySach()
        {
            InitializeComponent();
            Load += frmQuanLySach_Load;
        }


        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvSach.DataSource = _sachBll.SelectAll();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvSach.CurrentCell.RowIndex;

                string maSach = dgvSach.Rows[index].Cells[0].Value.ToString();
                string tenSach = dgvSach.Rows[index].Cells[1].Value.ToString();
                string theLoai = dgvSach.Rows[index].Cells[2].Value.ToString();
                string tenTacGia = dgvSach.Rows[index].Cells[3].Value.ToString();
                int namSanXuat = Int32.Parse(dgvSach.Rows[index].Cells[4].Value.ToString());
                int soLuongTon = Int32.Parse(dgvSach.Rows[index].Cells[5].Value.ToString());
                float donGia = float.Parse(dgvSach.Rows[index].Cells[6].Value.ToString());

                SachDTO sachDTO = new SachDTO();
                sachDTO.MaSach = maSach;
                sachDTO.TenSach = tenSach;
                sachDTO.TheLoai = theLoai;
                sachDTO.TacGia = tenTacGia;
                sachDTO.NamSanXuat = namSanXuat;
                sachDTO.SoLuongTon = soLuongTon;
                sachDTO.DonGiaBan = donGia;

                if (_sachBll.InsertSach(sachDTO) != 0)
                {
                    MessageBox.Show("Thêm phiếu thu tiền thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã sách !", "Lỗi!");
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
                int index = dgvSach.CurrentCell.RowIndex;

                string maSach = dgvSach.Rows[index].Cells[0].Value.ToString();
                string tenSach = dgvSach.Rows[index].Cells[1].Value.ToString();
                string theLoai = dgvSach.Rows[index].Cells[2].Value.ToString();
                string tenTacGia = dgvSach.Rows[index].Cells[3].Value.ToString();
                int namSanXuat = Int32.Parse(dgvSach.Rows[index].Cells[4].Value.ToString());
                int soLuongTon = Int32.Parse(dgvSach.Rows[index].Cells[5].Value.ToString());
                float donGia = float.Parse(dgvSach.Rows[index].Cells[6].Value.ToString());

                SachDTO sachDTO = new SachDTO();
                sachDTO.MaSach = maSach;
                sachDTO.TenSach = tenSach;
                sachDTO.TheLoai = theLoai;
                sachDTO.TacGia = tenTacGia;
                sachDTO.NamSanXuat = namSanXuat;
                sachDTO.SoLuongTon = soLuongTon;
                sachDTO.DonGiaBan = donGia;


                if (_sachBll.UpdateSach(sachDTO) != 0)
                {
                    MessageBox.Show("Cập nhật phiếu thành công !");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã sách !", "Lỗi!");
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
                int index = dgvSach.CurrentCell.RowIndex;

                string maSach = dgvSach.Rows[index].Cells[0].Value.ToString();
                string tenSach = dgvSach.Rows[index].Cells[1].Value.ToString();
                string theLoai = dgvSach.Rows[index].Cells[2].Value.ToString();
                string tenTacGia = dgvSach.Rows[index].Cells[3].Value.ToString();
                int namSanXuat = Int32.Parse(dgvSach.Rows[index].Cells[4].Value.ToString());
                int soLuongTon = Int32.Parse(dgvSach.Rows[index].Cells[5].Value.ToString());
                float donGia = float.Parse(dgvSach.Rows[index].Cells[6].Value.ToString());

                SachDTO sachDTO = new SachDTO();
                sachDTO.MaSach = maSach;
                sachDTO.TenSach = tenSach;
                sachDTO.TheLoai = theLoai;
                sachDTO.TacGia = tenTacGia;
                sachDTO.NamSanXuat = namSanXuat;
                sachDTO.SoLuongTon = soLuongTon;
                sachDTO.DonGiaBan = donGia;

                if (_sachBll.DeleteSachByMaSach(sachDTO) != 0)
                {
                    MessageBox.Show("Xoa Sách phiếu thành công !");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc  mã sách không tồn tại !", "Lỗi!");
                }
            }
            catch (Exception)
            {
            }
        }

        



    }
}
