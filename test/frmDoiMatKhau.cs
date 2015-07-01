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
    public partial class frmDoiMatKhau : Form
    {

        private TaiKhoanBLL _taiKhoanBll = new TaiKhoanBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            DataTable dtb = _taiKhoanBll.SelectAll();

            var tkString = txtTaiKhoan.Text.Trim();
            var mkString = txtMatKhau.Text.Trim();
            var mk1String = txtMatKhau1.Text.Trim();
            var mk2String = txtMatKhau2.Text.Trim();

            if (tkString == "" ||
                mkString == "" ||
                mk1String == "" ||
                mk2String == "")
            {
                MessageBox.Show("Không được để trống!");
                return;
            }

            if (mk1String != mk2String)
            {
                MessageBox.Show("2 mật khẩu không trùng khớp");
                return;
            }

            var query = from d in dtb.AsEnumerable()
                where d["TenTK"].ToString().Trim().Equals(tkString) &&
                      d["MatKhau"].ToString().Trim().Equals(mkString)
                select new
                {
                    MaTK = d["MaTK"],
                    TenTK = d["TenTK"],
                    MatKhau = d["MatKhau"],
                    LoaiTK = d["LoaiTK"]
                };

            DataTable dt = new DataTable();
            dt.Columns.Add("MaTK", typeof (int));
            dt.Columns.Add("TenTK", typeof (string));
            dt.Columns.Add("MatKhau", typeof (string));
            dt.Columns.Add("LoaiTK", typeof (int));

            if (query.Count() == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return;
            }

            foreach (var item in query)
            {
                dt.Rows.Add(item.MaTK,
                    item.TenTK,
                    item.MatKhau,
                    item.LoaiTK);
            }

            TaiKhoanDTO taiKhoanDto = new TaiKhoanDTO();
            taiKhoanDto.MaTaiKhoan = dt.Rows[0]["MaTK"].ToString();
            taiKhoanDto.TenTaiKhoan = dt.Rows[0]["TenTK"].ToString();
            taiKhoanDto.MatKhau = dt.Rows[0]["MatKhau"].ToString();
            taiKhoanDto.LoaiTaiKhoan = dt.Rows[0]["LoaiTK"].ToString();

            if (1 == _taiKhoanBll.UpdateTaiKhoan(taiKhoanDto))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
