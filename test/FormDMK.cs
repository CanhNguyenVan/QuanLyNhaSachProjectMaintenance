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
    public partial class FormDMK : Form
    {
        public FormDMK()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_MK1.Text = txt_MK2.Text = txt_ID.Text = txt_pass.Text = "";
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.Show();
        }

        private void btn_DMK_Click(object sender, EventArgs e)
        {
            //MySqlConnection.OpenConnection();
            //DataRow[] data = MySqlConnection.LoadData("TAIKHOAN1").Select("UserName = '" + txt_ID.Text + "'");
            //DataRow drow1;
            //try
            //{
            //    drow1 = data[0];
            //    if (txt_ID.Text == drow1.ItemArray.GetValue(0).ToString())
            //    {
            //        if (txt_pass.Text == drow1.ItemArray.GetValue(1).ToString())
            //        {
            //            if (txt_MK1.TextLength < 6)
            //            {
            //                MessageBox.Show("Mật khẩu phải hơn 6 kí tự!");
            //                txt_MK1.Text = txt_MK2.Text = "";
            //            }
            //            else
            //            {
            //                if (txt_MK1.Text != txt_MK2.Text)
            //                {
            //                    MessageBox.Show("Nhập lại mật khẩu sai! Vui lòng nhập lại");
            //                    txt_MK2.Text = "";
            //                }
            //                else
            //                {

            //                    string sql = string.Format("delete from TAIKHOAN1 where USERNAME = '{0}' ", txt_ID.Text);
            //                    MySqlConnection.Execute(sql);
            //                    string sql1 = string.Format("delete from TAIKHOAN1 where PASSWORD = '{0}' ", txt_pass);
            //                    MySqlConnection.Execute(sql1);
            //                    string sql2 = string.Format("insert into TAIKHOAN1 values ('{0}','{1}')", txt_ID.Text, txt_MK1.Text);
            //                    MySqlConnection.Execute(sql2);
            //                    MessageBox.Show("Bạn đã đổi mật khẩu thành công với tên đăng nhập là " + txt_ID.Text);
            //                }
            //            }    
            //        }
            //        else
            //        {
            //            MessageBox.Show("Mật khẩu không đúng! Xin vui lòng nhập lại! ");
            //            txt_ID.Text = txt_pass.Text = "";
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai! Xin vui lòng nhập lại! ");
            //    txt_ID.Text = txt_pass.Text = "";
            //}
        }
        
        


    }
}
