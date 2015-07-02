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
using DevComponents.DotNetBar;
using DevExpress.XtraPrinting.Native;

namespace test
{
    public partial class frmDangNhap : Form
    {

        public ButtonX BtnDangNhap
        {
            get { return btnDangNhap; }
            set { btnDangNhap = value; }
        }

        public TextBox TxtTaiKhoan
        {
            get { return txtTaiKhoan; }
        }

        public TextBox TxtMatKhau
        {
            get { return txtMatKhau; }
        }

        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            TaiKhoanBLL _taiKhoanBll = new TaiKhoanBLL();

            if (txtTaiKhoan.Text.IsEmpty() && txtMatKhau.Text.IsEmpty())
            {
                MessageBox.Show("Nhập tài khoản và mật khẩu!");
                return;
            }
            else if (txtTaiKhoan.Text.IsEmpty())
            {
                MessageBox.Show("Nhập tài khoản!");
                return;
            }
            else if (txtMatKhau.Text.IsEmpty())
            {
                MessageBox.Show("Nhập mật khẩu!");
                return;
            }

            var tk = _taiKhoanBll.SelectAll();

            var tkString = txtTaiKhoan.Text.Trim();
            var mkString = txtMatKhau.Text.Trim();

            var query = from dt in tk.AsEnumerable()
                        where dt["TenTK"].ToString().Trim().Equals(tkString) &&
                              dt["MatKhau"].ToString().Trim().Equals(mkString)
                        select new
                        {
                            MaTk = dt["MaTk"],
                            TenTK = dt["TenTK"],
                            MatKhau = dt["MatKhau"],
                            LoaiTK = dt["LoaiTK"]
                        };
            if (query.Count() == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập");
                return;
            }

            DataTable dtb = new DataTable("Tai Khoan");
            dtb.Columns.Add("MaTk", typeof(int));
            dtb.Columns.Add("TenTK", typeof(string));
            dtb.Columns.Add("MatKhau", typeof(string));
            dtb.Columns.Add("LoaiTK", typeof(int));

            foreach (var item in query)
            {
                dtb.Rows.Add(item.MaTk,
                    item.TenTK,
                    item.MatKhau,
                    item.LoaiTK);
            }

            if (int.Parse(dtb.Rows[0]["LoaiTK"].ToString()) == 1)
            {
                frmMain.LoaiTaiKhoan = 1;
            }
            else if (int.Parse(dtb.Rows[0]["LoaiTK"].ToString()) == 2)
            {
                frmMain.LoaiTaiKhoan = 2;
            }

        
            MessageBox.Show("Đăng nhập thành công!");
            this.Close();
        }

        
    }
}
