using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MK1.Text = txt_MK2.Text = txt_TenDN.Text = "";
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            //MySqlConnection.OpenConnection();
            //DataRow[] data = MySqlConnection.LoadData("TAIKHOAN1").Select("UserName = '" + txt_TenDN.Text + "'");
            //try
            //{
            //    if (txt_MK1.Text == "" || txt_MK2.Text == "" || txt_TenDN.Text == "")
            //    {
            //        MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            //    }
            //    else
            //    {
            //        if (txt_MK1.TextLength < 6)
            //        {
            //            MessageBox.Show("Mật khẩu phải hơn 6 kí tự!");
            //            txt_MK1.Text = txt_MK2.Text = "";
            //        }
            //        else
            //        {
            //            if (txt_MK1.Text != txt_MK2.Text)
            //            {
            //                MessageBox.Show("Nhập lại mật khẩu sai! Vui lòng nhập lại");
            //                txt_MK2.Text = "";
            //            }
            //            else
            //            {
            //                string sqlCommand = string.Format("insert into TAIKHOAN1 values ('{0}','{1}')", txt_TenDN.Text, txt_MK1.Text);
            //                MySqlConnection.Execute(sqlCommand);
            //                MessageBox.Show("Bạn đã đăng ký thành công với tên đăng nhập là " + txt_TenDN.Text);
            //                txt_MK1.Text = txt_MK2.Text = txt_TenDN.Text = "";
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Tên tài khoản đã tồn tại! Vui lòng nhập lại!");
            //    txt_MK1.Text = txt_MK2.Text = txt_TenDN.Text = "";
            //}
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.Show();
        }


    }
}
