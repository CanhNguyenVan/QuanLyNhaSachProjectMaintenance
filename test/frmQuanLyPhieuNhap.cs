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
    public partial class frmQuanLyPhieuNhap : Form
    {
        private PhieuNhapBLL _phieuNhapBll = new PhieuNhapBLL();
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
            Load += frmQuanLyPhieuNhap_Load;
        }


        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dgvQuanLyPhieuNhap.DataSource = _phieuNhapBll.SelectAll();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvQuanLyPhieuNhap.CurrentCell.RowIndex;

                string maPhieuNhap = dgvQuanLyPhieuNhap.Rows[index].Cells[0].Value.ToString();
                DateTime ngayNhap = DateTime.Parse(dgvQuanLyPhieuNhap.Rows[index].Cells[1].Value.ToString());

                PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                phieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                phieuNhapDTO.NgayNhap = ngayNhap;

                if (_phieuNhapBll.InsertPhieuNhap(phieuNhapDTO) == 1)
                {
                    MessageBox.Show("Thêm phiếu nhập tiền thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu nhập !", "Lỗi!");

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
                int index = dgvQuanLyPhieuNhap.CurrentCell.RowIndex;

                string maPhieuNhap = dgvQuanLyPhieuNhap.Rows[index].Cells[0].Value.ToString();
                DateTime ngayNhap = DateTime.Parse(dgvQuanLyPhieuNhap.Rows[index].Cells[1].Value.ToString());

                PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                phieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                phieuNhapDTO.NgayNhap = ngayNhap;

                if (_phieuNhapBll.UpdatePhieuNhap(phieuNhapDTO) == 1)
                {
                    MessageBox.Show("Sửa phiếu nhập tiền thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu nhập !", "Lỗi!");

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
                int index = dgvQuanLyPhieuNhap.CurrentCell.RowIndex;

                string maPhieuNhap = dgvQuanLyPhieuNhap.Rows[index].Cells[0].Value.ToString();
                DateTime ngayNhap = DateTime.Parse(dgvQuanLyPhieuNhap.Rows[index].Cells[1].Value.ToString());

                PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                phieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                phieuNhapDTO.NgayNhap = ngayNhap;

                if (_phieuNhapBll.DeleteByMaPhieuNhap(phieuNhapDTO) == 1)
                {
                    MessageBox.Show("Xóa phiếu nhập tiền thành công!");

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc không tồn tại mã phiếu nhập !", "Lỗi!");

                }
            }
            catch (Exception)
            {
            }
        }

        
    }
}
