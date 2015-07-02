using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BLL;
using DevComponents.DotNetBar;
using DevExpress.XtraPrinting.Native;
using DTO;
using TabControl = System.Windows.Forms.TabControl;


namespace test
{
    public partial class frmMain : Form
    {
        // Khai báo bussiness logic layer
        private DevComponents.DotNetBar.TabControl m_Tab;

        public static int LoaiTaiKhoan = 0;

                public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ThamSoBLL  thamSoBll = new ThamSoBLL();
            var dt = thamSoBll.SelectAll();

            ThamSo.ThamSoQuyDinh.MaThamSo = int.Parse(dt.Rows[0]["MaThamSo"].ToString().Trim());
            ThamSo.ThamSoQuyDinh.SoLuongNhapToiThieu = int.Parse(dt.Rows[0]["SoLuongNhapToiThieu"].ToString().Trim());
            ThamSo.ThamSoQuyDinh.SoLuongTonToiDaTruocKhiNhap = int.Parse(dt.Rows[0]["SoLuongTonToiDaTruocKhiNhap"].ToString().Trim());
            ThamSo.ThamSoQuyDinh.TienNoToiDa = int.Parse(dt.Rows[0]["TienNoToiDa"].ToString().Trim());
            ThamSo.ThamSoQuyDinh.SoLuongTonToiThieuSauKhiBan = int.Parse(dt.Rows[0]["SoLuongTonToiThieuSauKhiBan"].ToString().Trim());

            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            KhoiTaoQuyen(LoaiTaiKhoan);

        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Sách") == false)
            {
                frmQuanLySach form = new frmQuanLySach();
                AddTabControl(form, "Quản Lý Sách");
            }
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Khách Hàng") == false)
            {
                frmQuanLyKhachHang form = new frmQuanLyKhachHang();
                AddTabControl(form, "Quản Lý Khách Hàng");
            }
        }

        private void btn_PhieuNhap_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Phiếu Nhập") == false)
            {
                frmQuanLyPhieuNhap form = new frmQuanLyPhieuNhap();
                AddTabControl(form, "Quản Lý Phiếu Nhập");
            }
        }

        private void btn_PhieuThu_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Phiếu Thu") == false)
            {
                frmQuanLyPhieuThu form = new frmQuanLyPhieuThu();
                AddTabControl(form, "Quản Lý Phiếu Thu");
            }
        }

 
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            if (checkTab("Quản Lý Hóa Đơn") == false)
            {
                frmHoaDon form = new frmHoaDon();
                AddTabControl(form, "Quản Lý Hóa Đơn");
            }
        
        }

        private void btn_ThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            if (checkTab("Thay Đổi Quy Định") == false)
            {
                frmQuyDinh form = new frmQuyDinh();
                AddTabControl(form, "Thay Đổi Quy Định");
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (checkTab("Tìm Kiếm") == false)
            {
                frmTimKiem form = new frmTimKiem();
                AddTabControl(form, "Tìm Kiếm");
            }

        }

        private void btn_CongNo_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Công Nợ") == false)
            {
                frmBaoCaoCongNo form = new frmBaoCaoCongNo();
                AddTabControl(form, "Báo Cáo Công Nợ");
            }
        }

        private void btn_Ton_Click(object sender, EventArgs e)
        {
            if (checkTab("Báo Cáo Tồn") == false)
            {
                frmBaoCaoTon form = new frmBaoCaoTon();
                AddTabControl(form, "Báo Cáo Tồn");
            }

        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
           
        }

        
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
   
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            KhoiTaoQuyen(LoaiTaiKhoan);
        }

        private void KhoiTaoQuyen(int loaiTaiKhoan)
        {
            if (loaiTaiKhoan == 1)
            {
                btn_ThayDoiQuyDinh.Enabled =
                    btn_TimKiem.Enabled =
                        btn_Sach.Enabled =
                            btn_KhachHang.Enabled =
                                btn_PhieuNhap.Enabled =
                                    btn_PhieuThu.Enabled =
                                        btn_HoaDon.Enabled =
                                            btn_CongNo.Enabled =
                                                btn_Ton.Enabled =
                                                    btnBackupRestore.Enabled = true;
            }
            if (loaiTaiKhoan == 2)
            {
                btn_CongNo.Enabled =
                    btn_Ton.Enabled =
                        btnBackupRestore.Enabled = false;
            }
            else if (loaiTaiKhoan == 0)
            {
                btn_ThayDoiQuyDinh.Enabled =
                    btn_TimKiem.Enabled =
                        btn_Sach.Enabled =
                            btn_KhachHang.Enabled =
                                btn_PhieuNhap.Enabled =
                                    btn_PhieuThu.Enabled =
                                        btn_HoaDon.Enabled =
                                            btn_CongNo.Enabled =
                                                btn_Ton.Enabled =
                                                    btnBackupRestore.Enabled = false;

            }
        }


        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            if (checkTab("Đổi Mật Khẩu") == false)
            {
                frmDoiMatKhau form = new frmDoiMatKhau();
                AddTabControl(form, "Đổi Mật Khẩu");
            }
        }


        public void AddTabControl(Form form, string nameTab)
        {
            TabItem tab = tabControl2.CreateTab(nameTab);
            form.Dock = DockStyle.Fill;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            tab.AttachedControl.Controls.Add(form);
            form.Show();
            tabControl2.SelectedTabIndex = tabControl2.Tabs.Count - 1;
            m_Tab = tabControl2;
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tabControl2.Tabs.Count; i++)
            {
                if (tabControl2.Tabs[i].Text == name)
                {
                    tabControl2.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            if (checkTab("Backup/Restore") == false)
            {
                frmBackupAndRestore form = new frmBackupAndRestore();
                AddTabControl(form, "Backup/Restore");
            }
        }

        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
