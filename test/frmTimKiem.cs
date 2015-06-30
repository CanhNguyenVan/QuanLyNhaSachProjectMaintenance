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

namespace test
{
    public partial class frmTimKiem : Form
    {
        private SachBLL _sachBll = new SachBLL();

        private DataTable _data = null;

        public frmTimKiem()
        {
            InitializeComponent();

            _data = _sachBll.SelectAll();

            cbxLoaiTimKiem.SelectedIndex = 0;
        }

        private void txtMaSach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
        private object SearchByMaSach(string q)
        {
            var query = from dt in _data.AsEnumerable()
                        where dt["MaSach"].ToString().Trim().ToLower().Contains(q.Trim().ToLower())
                        select new
                        {
                            MaSach = dt["MaSach"],
                            TenSach = dt["TenSach"],
                            TheLoai = dt["TheLoai"],
                            TacGia = dt["TacGia"],
                            NamXuatBan = dt["NamXuatBan"],
                            SoLuongTon = dt["SoLuongTon"],
                            DonGiaBan = dt["DonGiaBan"]

                        };

            DataTable dataTable = new DataTable("Kết quả tìm kiếm");

            dataTable.Columns.Add("MaSach", typeof(string));
            dataTable.Columns.Add("TenSach", typeof(string));
            dataTable.Columns.Add("TheLoai", typeof(string));
            dataTable.Columns.Add("TacGia", typeof(string));
            dataTable.Columns.Add("NamXuatBan", typeof(int));
            dataTable.Columns.Add("SoLuongTon", typeof(int));
            dataTable.Columns.Add("DonGiaBan", typeof(float));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.MaSach,
                    item.TenSach,
                    item.TheLoai,
                    item.TacGia,
                    item.NamXuatBan,
                    item.SoLuongTon,
                    item.DonGiaBan
                    );
            }

            return dataTable;
        }

        private object SearchByTenSach(string q)
        {
            var query = from dt in _data.AsEnumerable()
                        where dt["TenSach"].ToString().Trim().ToLower().Contains(q.Trim().ToLower())
                        select new
                        {
                            MaSach = dt["MaSach"],
                            TenSach = dt["TenSach"],
                            TheLoai = dt["TheLoai"],
                            TacGia = dt["TacGia"],
                            NamXuatBan = dt["NamXuatBan"],
                            SoLuongTon = dt["SoLuongTon"],
                            DonGiaBan = dt["DonGiaBan"]

                        };

            DataTable dataTable = new DataTable("Kết quả tìm kiếm");

            dataTable.Columns.Add("MaSach", typeof(string));
            dataTable.Columns.Add("TenSach", typeof(string));
            dataTable.Columns.Add("TheLoai", typeof(string));
            dataTable.Columns.Add("TacGia", typeof(string));
            dataTable.Columns.Add("NamXuatBan", typeof(int));
            dataTable.Columns.Add("SoLuongTon", typeof(int));
            dataTable.Columns.Add("DonGiaBan", typeof(float));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.MaSach,
                    item.TenSach,
                    item.TheLoai,
                    item.TacGia,
                    item.NamXuatBan,
                    item.SoLuongTon,
                    item.DonGiaBan
                    );
            }

            return dataTable;
        }

        private object SearchByTheLoai(string q)
        {
            var query = from dt in _data.AsEnumerable()
                        where dt["TheLoai"].ToString().Trim().ToLower().Contains(q.Trim().ToLower())
                        select new
                        {
                            MaSach = dt["MaSach"],
                            TenSach = dt["TenSach"],
                            TheLoai = dt["TheLoai"],
                            TacGia = dt["TacGia"],
                            NamXuatBan = dt["NamXuatBan"],
                            SoLuongTon = dt["SoLuongTon"],
                            DonGiaBan = dt["DonGiaBan"]

                        };

            DataTable dataTable = new DataTable("Kết quả tìm kiếm");

            dataTable.Columns.Add("MaSach", typeof(string));
            dataTable.Columns.Add("TenSach", typeof(string));
            dataTable.Columns.Add("TheLoai", typeof(string));
            dataTable.Columns.Add("TacGia", typeof(string));
            dataTable.Columns.Add("NamXuatBan", typeof(int));
            dataTable.Columns.Add("SoLuongTon", typeof(int));
            dataTable.Columns.Add("DonGiaBan", typeof(float));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.MaSach,
                    item.TenSach,
                    item.TheLoai,
                    item.TacGia,
                    item.NamXuatBan,
                    item.SoLuongTon,
                    item.DonGiaBan
                    );
            }

            return dataTable;
        }

        private object SearchByTacGia(string q)
        {
            var query = from dt in _data.AsEnumerable()
                        where dt["TacGia"].ToString().Trim().ToLower().Contains(q.Trim().ToLower())
                        select new
                        {
                            MaSach = dt["MaSach"],
                            TenSach = dt["TenSach"],
                            TheLoai = dt["TheLoai"],
                            TacGia = dt["TacGia"],
                            NamXuatBan = dt["NamXuatBan"],
                            SoLuongTon = dt["SoLuongTon"],
                            DonGiaBan = dt["DonGiaBan"]

                        };

            DataTable dataTable = new DataTable("Kết quả tìm kiếm");

            dataTable.Columns.Add("MaSach", typeof(string));
            dataTable.Columns.Add("TenSach", typeof(string));
            dataTable.Columns.Add("TheLoai", typeof(string));
            dataTable.Columns.Add("TacGia", typeof(string));
            dataTable.Columns.Add("NamXuatBan", typeof(int));
            dataTable.Columns.Add("SoLuongTon", typeof(int));
            dataTable.Columns.Add("DonGiaBan", typeof(float));

            foreach (var item in query)
            {
                dataTable.Rows.Add(item.MaSach,
                    item.TenSach,
                    item.TheLoai,
                    item.TacGia,
                    item.NamXuatBan,
                    item.SoLuongTon,
                    item.DonGiaBan
                    );
            }

            return dataTable;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            switch (cbxLoaiTimKiem.SelectedIndex)
            {
                case 0:
                    dgvTimKiem.DataSource = SearchByMaSach(txtQuery.Text);
                    break;
                case 1:
                    dgvTimKiem.DataSource = SearchByTenSach(txtQuery.Text);
                    break;
                case 2:
                    dgvTimKiem.DataSource = SearchByTheLoai(txtQuery.Text);
                    break;
                case 3:
                    dgvTimKiem.DataSource = SearchByTacGia(txtQuery.Text);
                    break;
                default:
                    break;
            }
        }


    }
}
