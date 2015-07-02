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
using DevComponents.DotNetBar.Controls;
using DTO;

namespace test
{
    public partial class frmHoaDon : Form
    {
        private HoaDonBLL _hoaDonBll = new HoaDonBLL();

        private ChiTietHoaDonBLL _chiTietHoaDonBll = new ChiTietHoaDonBLL();

        private KhachHangBLL _khachHangBll = new KhachHangBLL();

        private SachBLL _sachBll = new SachBLL();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon();

            LoadDataChiTietHoaDon();
        }

        private void LoadDataChiTietHoaDon()
        {
            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachBll.SelectAll();
            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";


            dgvChiTietHoaDon.DataSource = _chiTietHoaDonBll.SelectAll();
        }

        private void LoadDataHoaDon()
        {


            (dgvHoaDon.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).DataSource = _khachHangBll.SelectAll();
            (dgvHoaDon.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
            (dgvHoaDon.Columns["MaKhachHang"] as DataGridViewComboBoxColumn).ValueMember = "MaKhachHang";

            dgvHoaDon.DataSource = _hoaDonBll.SelectAll();

            //(dgvHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachBll.SelectAll();
            //(dgvHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            //(dgvHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";

        }

        private void btnLamMoiHoaDon_Click(object sender, EventArgs e)
        {
            LoadDataHoaDon();
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHoaDon.CurrentCell.RowIndex;

                string maHoaDon = dgvHoaDon.Rows[index].Cells[0].Value.ToString();

                LoadDataChiTietHoaDon(maHoaDon);
            }
            catch (Exception)
            {
                
            }
        }

        private void LoadDataChiTietHoaDon(string maHoaDon)
        {
            var chiTietHoaDonTb = _chiTietHoaDonBll.SelectAll();
            var query = from t in chiTietHoaDonTb.AsEnumerable()
                where t["MaHoaDon"].ToString().Trim().Equals(maHoaDon.Trim(), StringComparison.InvariantCultureIgnoreCase)
                select new
                {
                    MaChiTietHoaDon = t["MaChiTietHoaDon"],
                    MaHoaDon = t["MaHoaDon"],
                    MaSach = t["MaSach"],
                    SoLuongBan = t["SoLuongBan"]
                };

            DataTable result = new DataTable();
            result.Columns.Add("MaChiTietHoaDon", typeof (string));
            result.Columns.Add("MaHoaDon", typeof (string));
            result.Columns.Add("MaSach", typeof (string));
            result.Columns.Add("SoLuongBan", typeof (int));

            foreach (var item in query)
            {
                result.Rows.Add(item.MaChiTietHoaDon, item.MaHoaDon,
                    item.MaSach, item.SoLuongBan);
            }

            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DataSource = _sachBll.SelectAll();
            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).DisplayMember = "TenSach";
            (dgvChiTietHoaDon.Columns["MaSach"] as DataGridViewComboBoxColumn).ValueMember = "MaSach";

            dgvChiTietHoaDon.DataSource = result;

        }

        private void btnLamMoiChiTietHoaDon_Click(object sender, EventArgs e)
        {
            LoadDataChiTietHoaDon();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHoaDon.CurrentCell.RowIndex;
                string maHoaDon = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
                string maKhachHang = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
                DateTime ngayLap = DateTime.Parse(dgvHoaDon.Rows[index].Cells[2].Value.ToString());

                HoaDonDTO hoaDonDto = new HoaDonDTO();
                hoaDonDto.MaHoaDon = maHoaDon;
                hoaDonDto.MaKhachHang = maKhachHang;
                hoaDonDto.NgayLap = ngayLap;

                if (0 != _hoaDonBll.InsertHoaDon(hoaDonDto))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc trường nhập vào bị trống hoặc trùng khóa chính", "Lỗi");
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHoaDon.CurrentCell.RowIndex;
                string maHoaDon = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
                string maKhachHang = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
                DateTime ngayLap = DateTime.Parse(dgvHoaDon.Rows[index].Cells[2].Value.ToString());

                HoaDonDTO hoaDonDto = new HoaDonDTO();
                hoaDonDto.MaHoaDon = maHoaDon;
                hoaDonDto.MaKhachHang = maKhachHang;
                hoaDonDto.NgayLap = ngayLap;

                if (0 != _hoaDonBll.UpdateHoaDon(hoaDonDto))
                {
                    MessageBox.Show("Sửa hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc trường nhập vào bị trống hoặc lỗi khóa chính", "Lỗi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHoaDon.CurrentCell.RowIndex;
                string maHoaDon = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
                string maKhachHang = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
                DateTime ngayLap = DateTime.Parse(dgvHoaDon.Rows[index].Cells[2].Value.ToString());

                HoaDonDTO hoaDonDto = new HoaDonDTO();
                hoaDonDto.MaHoaDon = maHoaDon;
                hoaDonDto.MaKhachHang = maKhachHang;
                hoaDonDto.NgayLap = ngayLap;

                if (0 != _hoaDonBll.DeleteByMaHoaDon(hoaDonDto))
                {
                    MessageBox.Show("Xóa hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc khóa chính không tồn tại", "Lỗi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnThemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvChiTietHoaDon.CurrentCell.RowIndex;
                string maChiTietHoaDon = dgvChiTietHoaDon.Rows[index].Cells[0].Value.ToString();
                string maHoaDon = dgvChiTietHoaDon.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietHoaDon.Rows[index].Cells[2].Value.ToString();
                int soLuongBan = int.Parse(dgvChiTietHoaDon.Rows[index].Cells[3].Value.ToString());

                ChiTietHoaDonDTO chiTietHoaDonDto = new ChiTietHoaDonDTO();
                chiTietHoaDonDto.MaChiTietHoaDon = maChiTietHoaDon;
                chiTietHoaDonDto.MaHoaDon = maHoaDon;
                chiTietHoaDonDto.MaSach = maSach;
                chiTietHoaDonDto.SoLuongBan = soLuongBan;

                if (0 != _chiTietHoaDonBll.InsertChiTietHoaDon(chiTietHoaDonDto))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc trường nhập vào bị trống hoặc trùng khóa chính", "Lỗi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnSuaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvChiTietHoaDon.CurrentCell.RowIndex;
                string maChiTietHoaDon = dgvChiTietHoaDon.Rows[index].Cells[0].Value.ToString();
                string maHoaDon = dgvChiTietHoaDon.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietHoaDon.Rows[index].Cells[2].Value.ToString();
                int soLuongBan = int.Parse(dgvChiTietHoaDon.Rows[index].Cells[3].Value.ToString());

                ChiTietHoaDonDTO chiTietHoaDonDto = new ChiTietHoaDonDTO();
                chiTietHoaDonDto.MaChiTietHoaDon = maChiTietHoaDon;
                chiTietHoaDonDto.MaHoaDon = maHoaDon;
                chiTietHoaDonDto.MaSach = maSach;
                chiTietHoaDonDto.SoLuongBan = soLuongBan;

                if (0 != _chiTietHoaDonBll.UpdateChiTietPhieuNhap(chiTietHoaDonDto))
                {
                    MessageBox.Show("Sửa hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc trường nhập vào bị trống hoặc lỗi khóa chính", "Lỗi");
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnXoaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvChiTietHoaDon.CurrentCell.RowIndex;
                string maChiTietHoaDon = dgvChiTietHoaDon.Rows[index].Cells[0].Value.ToString();
                string maHoaDon = dgvChiTietHoaDon.Rows[index].Cells[1].Value.ToString();
                string maSach = dgvChiTietHoaDon.Rows[index].Cells[2].Value.ToString();
                int soLuongBan = int.Parse(dgvChiTietHoaDon.Rows[index].Cells[3].Value.ToString());

                ChiTietHoaDonDTO chiTietHoaDonDto = new ChiTietHoaDonDTO();
                chiTietHoaDonDto.MaChiTietHoaDon = maChiTietHoaDon;
                chiTietHoaDonDto.MaHoaDon = maHoaDon;
                chiTietHoaDonDto.MaSach = maSach;
                chiTietHoaDonDto.SoLuongBan = soLuongBan;

                if (0 != _chiTietHoaDonBll.DeleteByMaChiTietPhieuNhap(chiTietHoaDonDto))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");

                    LoadDataHoaDon();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra hoặc khóa chính không tồn tại", "Lỗi");
                }
            }
            catch (Exception)
            {

            }
        }


    }
}
