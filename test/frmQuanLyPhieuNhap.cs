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
        private SachBLL _sachBll = new SachBLL();
        private ChiTietPhieuNhapBLL _chiTietPhieuNhapBll = new ChiTietPhieuNhapBLL();
        public frmQuanLyPhieuNhap()
        {
            InitializeComponent();
            Load += frmQuanLyPhieuNhap_Load;
         
        }


        private void frmQuanLyPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDataPhieuNhap();
            LoadDataChiTietPhieuNhap();
        }
        private void LoadDataPhieuNhap()
        {
            dgvQuanLyPhieuNhap.DataSource = _phieuNhapBll.SelectAll();
        }


        private void LoadDataChiTietPhieuNhap()
        {

            (dgvChiTietPhieuNhap.Columns["MaPhieuNhap"] as DataGridViewComboBoxColumn).DataSource = _sachBll.SelectAll();
            (dgvChiTietPhieuNhap.Columns["MaPhieuNhap"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            (dgvChiTietPhieuNhap.Columns["MaPhieuNhap"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";

            dgvChiTietPhieuNhap.DataSource = _sachBll.SelectAll();
        }

        private void LoadDataChiTietPhieuNhap(string maPhieuNhap)
        {
            var chiTietPhieuNhapTb = _chiTietPhieuNhapBll.SelectAll();
            var query = from t in chiTietPhieuNhapTb.AsEnumerable()
                        where t["MaPhieuNhap"].ToString().Trim().Equals(maPhieuNhap.Trim(), StringComparison.InvariantCultureIgnoreCase)
                        select new
                        {
                            MaChiTietPhieuNhap = t["MaChiTietPhieuNhap"],
                            MaPhieuNhap = t["MaPhieuNhap"],
                            MaSach = t["MaSach"],
                            SoLuongNhap = t["SoLuongNhap"],
                            DonGiaNhap = t["DonGiaNhap"]
                        };

            DataTable result = new DataTable();
            result.Columns.Add("MaChiTietPhieuNhap", typeof(string));
            result.Columns.Add("MaPhieuNhap", typeof(string));
            result.Columns.Add("MaSach", typeof(string));
            result.Columns.Add("SoLuongNhap", typeof(int));
            result.Columns.Add("DonGiaNhap", typeof(float));

            foreach (var item in query)
            {
                result.Rows.Add(item.MaChiTietPhieuNhap, item.MaPhieuNhap,
                    item.MaSach, item.SoLuongNhap,item.DonGiaNhap);
            }

            (dgvChiTietPhieuNhap.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachBll.SelectAll();
            (dgvChiTietPhieuNhap.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            (dgvChiTietPhieuNhap.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";          

            dgvChiTietPhieuNhap.DataSource = result;
        }
        private void dgvQuanLyPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvQuanLyPhieuNhap.CurrentCell.RowIndex;

                string maPhieuNhap = dgvQuanLyPhieuNhap.Rows[index].Cells[0].Value.ToString();

                LoadDataChiTietPhieuNhap(maPhieuNhap);
            }
            catch (Exception)
            {

            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            LoadDataPhieuNhap();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
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

                    LoadDataPhieuNhap();
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

        private void btnSua_Click_1(object sender, EventArgs e)
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

                    LoadDataPhieuNhap();
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

        private void btnXoa_Click_1(object sender, EventArgs e)
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

                    LoadDataPhieuNhap();
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

        private void btnLamMoi1_Click_1(object sender, EventArgs e)
        {
                LoadDataChiTietPhieuNhap();
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dgvChiTietPhieuNhap.CurrentCell.RowIndex;

                string maChiTietPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[0].Value.ToString();
                string maPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietPhieuNhap.Rows[index].Cells[2].Value.ToString();
                int soLuongNhap = Int32.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[3].Value.ToString());
                float donGiaNhap = float.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[4].Value.ToString());
                

                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = maChiTietPhieuNhap;
                chiTietPhieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                chiTietPhieuNhapDTO.MaSach = maSach;
                chiTietPhieuNhapDTO.SoLuongNhap = soLuongNhap;
                
                chiTietPhieuNhapDTO.DonGiaNhap = donGiaNhap;

                if ( _chiTietPhieuNhapBll.InsertChiTietPhieuNhap(chiTietPhieuNhapDTO) == 1)
                {
                    MessageBox.Show("Thêm Thông Tin chi tiết phiếu nhập tiền thành công!");

                    LoadDataPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu chi tiết phiếu nhập !", "Lỗi!");

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSua1_Click(object sender, EventArgs e)
        {
            try
            {

                int index = dgvChiTietPhieuNhap.CurrentCell.RowIndex;

                string maChiTietPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[0].Value.ToString();
                string maPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietPhieuNhap.Rows[index].Cells[2].Value.ToString();
                int soLuongNhap = Int32.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[3].Value.ToString());
                float donGiaNhap = float.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[4].Value.ToString());


                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = maChiTietPhieuNhap;
                chiTietPhieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                chiTietPhieuNhapDTO.MaSach = maSach;
                chiTietPhieuNhapDTO.SoLuongNhap = soLuongNhap;
                chiTietPhieuNhapDTO.DonGiaNhap = donGiaNhap;

                if (_chiTietPhieuNhapBll.UpdateChiTietPhieuNhap(chiTietPhieuNhapDTO) == 1)
                {
                    MessageBox.Show("Sửa Thông Tin chi tiết phiếu nhập tiền thành công!");

                    LoadDataPhieuNhap();
                }
                else
                {
                    MessageBox.Show(" Lỗi Nhập không tồn tại mã chi tiết phiếu nhập hoặc sửa thông tin bị lỗi !", "Lỗi!");

                }
            }
            catch (Exception)
            {

            }

        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvChiTietPhieuNhap.CurrentCell.RowIndex;

                string maChiTietPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[0].Value.ToString();
                string maPhieuNhap = dgvChiTietPhieuNhap.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietPhieuNhap.Rows[index].Cells[2].Value.ToString();
                int soLuongNhap = Int32.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[3].Value.ToString());
                float donGiaNhap = Int32.Parse(dgvChiTietPhieuNhap.Rows[index].Cells[4].Value.ToString());


                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = maChiTietPhieuNhap;
                chiTietPhieuNhapDTO.MaPhieuNhap = maPhieuNhap;
                chiTietPhieuNhapDTO.MaSach = maSach;
                chiTietPhieuNhapDTO.SoLuongNhap = soLuongNhap;
                chiTietPhieuNhapDTO.DonGiaNhap = donGiaNhap;

                if (_chiTietPhieuNhapBll.DeleteByMaChiTietPhieuNhap(chiTietPhieuNhapDTO) == 1)
                {
                    MessageBox.Show("Sửa Thông Tin chi tiết phiếu nhập tiền thành công!");

                    LoadDataPhieuNhap();
                }
                else
                {
                    MessageBox.Show(" Lỗi Nhập không tồn tại mã chi tiết phiếu nhập !", "Lỗi!");

                }
            }
            catch (Exception)
            {
            }
        }
    }
}
