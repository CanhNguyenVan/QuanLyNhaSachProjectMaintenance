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
    public partial class frmQuyDinh : Form
    {

        private ThamSoBLL _thamSoBll = new ThamSoBLL();
        public frmQuyDinh()
        {
            InitializeComponent();

            Load += frmQuyDinh_Load;
        }

        void frmQuyDinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {

            txt_SLNhapItNhat.Text = ThamSo.ThamSoQuyDinh.SoLuongNhapToiThieu.ToString();
            txt_TonToiDaTruocKhiNhap.Text = ThamSo.ThamSoQuyDinh.SoLuongTonToiDaTruocKhiNhap.ToString();
            txt_TienNoToiDa.Text = ThamSo.ThamSoQuyDinh.TienNoToiDa.ToString();
            txt_TonToiThieuSauBan.Text = ThamSo.ThamSoQuyDinh.SoLuongTonToiThieuSauKhiBan.ToString();
        }

        private void btn_TDQD_Click(object sender, EventArgs e)
        {
            if (_thamSoBll.UpdateThamSo(ThamSo.ThamSoQuyDinh) != 0)
            {
                MessageBox.Show("Sửa thành công!");
                var dt = _thamSoBll.SelectAll();
                ThamSo.ThamSoQuyDinh.SoLuongNhapToiThieu = int.Parse(dt.Rows[0]["SoLuongNhapToiThieu"].ToString().Trim());
                ThamSo.ThamSoQuyDinh.SoLuongTonToiDaTruocKhiNhap = int.Parse(dt.Rows[0]["SoLuongTonToiDaTruocKhiNhap"].ToString().Trim());
                ThamSo.ThamSoQuyDinh.TienNoToiDa = int.Parse(dt.Rows[0]["TienNoToiDa"].ToString().Trim());
                ThamSo.ThamSoQuyDinh.SoLuongTonToiThieuSauKhiBan = int.Parse(dt.Rows[0]["SoLuongTonToiThieuSauKhiBan"].ToString().Trim());

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_TienNoToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void isUsingQuyDinh4_CheckedChanged(object sender, EventArgs e)
        {
            if (isUsingQuyDinh4.Checked == true)
            {
                ThamSo.IsUsingQuyDinh4 = true;
            }
            else
            {
                ThamSo.IsUsingQuyDinh4 = false;
            }
        }
    }
}
