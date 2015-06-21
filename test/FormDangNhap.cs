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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKy formDK = new FormDangKy();
            formDK.Show();
        }

        private void btn_DN_Click(object sender, EventArgs e)
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
            //            this.Hide();
            //            Form1 form = new Form1();
            //            form.Show();
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
            //    MessageBox.Show("Bạn chưa nhập hoặc nhập sai mật khẩu! Xin vui lòng nhập lại! ");
            //    txt_ID.Text = txt_pass.Text = "";
            //}
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDMK formDMK = new FormDMK();
            formDMK.Show();
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_DN_Click(sender, e);
            }
        }

        private void txt_ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_DN_Click(sender, e);
            }
        }

        
    }
}
