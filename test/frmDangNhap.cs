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

        
    }
}
