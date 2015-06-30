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
using DTO;
using TabControl = System.Windows.Forms.TabControl;


namespace test
{
    public partial class frmMain : Form
    {
        // Khai báo bussiness logic layer
        

        // Form
        private frmQuanLyPhieuThu _frmQuanLyPhieuThu = null;

        private frmHoaDon _frmHoaDon = null;

        private frmQuyDinh _frmQuyDinh = null;

        private frmTimKiem _frmTimKiem = null;
        public frmMain()
        {
            InitializeComponent();
            //tabItem16.Visible = true;
            //tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = false;
            //this.MaximizeBox = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            ////if (isTabQL)
            //{
            //    tabItem5.Visible = true;
            //    tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            //}

            //dataGridView_Sach.DataSource = MySqlConnection.LoadData("SACH");
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            ////if (isTabQL)
            //{
            //    tabItem6.Visible = true;
            //    tabItem5.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            //}

            //dataGridView_KH.DataSource = MySqlConnection.LoadData("KHACHHANG");
        }

        private void btn_PhieuNhap_Click(object sender, EventArgs e)
        {
            ////if (isTabQL)
            //{
            //    tabItem7.Visible = true;
            //    tabItem5.Visible = tabItem6.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            //}

            //dataGridView_PhieuNhap.DataSource = MySqlConnection.LoadData("CHITIETPHIEUNHAP");
            //dataGridView_PhieuNhapTQ.DataSource = MySqlConnection.LoadData("PHIEUNHAP");
        }

        private void btn_PhieuThu_Click(object sender, EventArgs e)
        {
            if (_frmQuanLyPhieuThu == null)
            {
                _frmQuanLyPhieuThu = new frmQuanLyPhieuThu();
                _frmQuanLyPhieuThu.Closed += _frmQuanLyPhieuThu_Closed;
                _frmQuanLyPhieuThu.MdiParent = this;
            }
            
            _frmQuanLyPhieuThu.Show();

            //LoadDataPhieuThu();
        }

        void _frmQuanLyPhieuThu_Closed(object sender, EventArgs e)
        {
            _frmQuanLyPhieuThu = null;
        }




     

 
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            ////if (isTabQL)
            //{
            //tabItem9.Visible = true;
            //    tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            //}

            //dataGridView_HoaDon.DataSource = MySqlConnection.LoadData("CHITIETHOADON");
            //dataGridView_HoaDonTQ.DataSource = MySqlConnection.LoadData("HOADON");

            if (_frmHoaDon == null)
            {
                _frmHoaDon = new frmHoaDon();
                _frmHoaDon.Closed += _frmHoaDon_Closed;
                _frmHoaDon.MdiParent = this;
            }

            _frmHoaDon.Show();
        
        }

        void _frmHoaDon_Closed(object sender, EventArgs e)
        {
            _frmHoaDon = null;
        }


        private void btn_ThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            ////if (isTabHT)
            //{
            //    tabItem14.Visible = true;
            //    tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem15.Visible = tabItem16.Visible = false;
            //}
            //txt_SLNhapItNhat.Text = txt_TonToiDaTruocKhiNhap.Text = txt_TonToiThieuSauBan.Text = txt_TienNoToiDa.Text = "";

            if (_frmQuyDinh == null)
            {
                _frmQuyDinh = new frmQuyDinh();
                _frmQuyDinh.Closed += _frmQuyDinh_Closed;
                _frmQuyDinh.MdiParent = this;
            }

            _frmQuyDinh.Show();
        }

        void _frmQuyDinh_Closed(object sender, EventArgs e)
        {
            _frmQuyDinh = null;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            ////if (isTabHT)
            //{
            //    tabItem15.Visible = true;
            //    tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem16.Visible = false;
            //}

            if (_frmTimKiem == null)
            {
                _frmTimKiem = new frmTimKiem();
                _frmTimKiem.Closed += _frmTimKiem_Closed;
                _frmTimKiem.MdiParent = this;
            }

            _frmTimKiem.Show();
        }

        void _frmTimKiem_Closed(object sender, EventArgs e)
        {
            _frmTimKiem = null;}

        private void btn_CongNo_Click(object sender, EventArgs e)
        {
            //if (isTabTK)
            {
                tabItem10.Visible = true;
                tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem11.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            }


        }

        private void btn_Ton_Click(object sender, EventArgs e)
        {
            //if (isTabTK)
            {
                tabItem11.Visible = true;
                tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem12.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            }


        }

        private void btn_TroGiup_Click(object sender, EventArgs e)
        {
            //if (isTabTG)
            {
                tabItem12.Visible = true;
                tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem13.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            }
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            //if (isTabTG)
            {
                tabItem13.Visible = true;
                tabItem5.Visible = tabItem6.Visible = tabItem7.Visible = tabItem8.Visible = tabItem9.Visible = tabItem10.Visible = tabItem11.Visible = tabItem12.Visible = tabItem14.Visible = tabItem15.Visible = tabItem16.Visible = false;
            }
        }


        private void btn_ThemSach_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData("SACH");
            //    int i = tb.Rows.Count + 1;
            //    string masach = "SA" + i;
            //    string sql = string.Format("insert into SACH (MASACH,TENSACH,THELOAI,TACGIA,DONGIA,NAMXUATBAN) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}') ", masach , txt_TenSach.Text, txt_TheLoai.Text, txt_TenTacGia.Text, txt_DonGia.Text, txt_NamSanXuat.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_XoaSach_Click(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedcell in dataGridView_Sach.SelectedCells)
            //{
            //    cell = selectedcell;
            //    break;
            //}

            //DataGridViewRow row = cell.OwningRow;
            //string sql = string.Format("delete from SACH where MASACH = '{0}' ", row.Cells["MASACH"].Value.ToString());
            //MySqlConnection.Execute(sql);
            //UpdateTable();
        }

        private void btn_SuaSach_Click(object sender, EventArgs e)
        {
            

            //try
            //{
            //    DataGridViewCell cell = null;
            //    foreach (DataGridViewCell selectedcell in dataGridView_Sach.SelectedCells)
            //    {
            //        cell = selectedcell;
            //        break;
            //    }

            //    DataGridViewRow row = cell.OwningRow;

            //    string masach, tentacgia, theloai, dongia, tensach, namsx;
            //    masach = txt_MaSach.Text;
            //    tensach = txt_TenSach.Text;
            //    theloai = txt_TheLoai.Text;
            //    tentacgia = txt_TenTacGia.Text;
            //    dongia = txt_DonGia.Text;
            //    namsx = txt_NamSanXuat.Text;

            //    string sql = string.Format("delete from SACH where MASACH = '{0}' ", row.Cells["MASACH"].Value.ToString());
            //    MySqlConnection.Execute(sql);
            //    string sql1 = string.Format("insert into SACH (MASACH,TENSACH,THELOAI,TACGIA,DONGIA,NAMXUATBAN) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}') ", txt_MaSach.Text, txt_TenSach.Text, txt_TheLoai.Text, txt_TenTacGia.Text, txt_DonGia.Text, txt_NamSanXuat.Text);
            //    MySqlConnection.Execute(sql1);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Sửa không thành công!");
            //}
        }

        private void dataGridView_Sach_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_Sach.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_MaSach.Text = row.Cells["MASACH"].Value.ToString();
                txt_TenSach.Text = row.Cells["TENSACH"].Value.ToString();
                txt_TheLoai.Text = row.Cells["THELOAI"].Value.ToString();
                txt_TenTacGia.Text = row.Cells["TACGIA"].Value.ToString();
                txt_DonGia.Text = row.Cells["DONGIA"].Value.ToString();
                txt_NamSanXuat.Text = row.Cells["NAMXUATBAN"].Value.ToString();
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData("KHACHHANG");
            //    int i = tb.Rows.Count + 1;
            //    string makh = "KH" + i;
            //    string sql = string.Format("insert into KHACHHANG (MAKHACHHANG,HOTEN,DIACHI,EMAIL,DIENTHOAI,SOTIENNO) values ('{0}', '{1}', '{2}', '{3}', '{4}' , '{5}') ", makh, txt_TenKH.Text, txt_DiaChiKH.Text, txt_EmailKH.Text, txt_SdtKH.Text, txt_TienNo.Text);
            //    MySqlConnection.Execute(sql);
            //    dataGridView_KH.DataSource = MySqlConnection.LoadData("KHACHHANG");
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedcell in dataGridView_KH.SelectedCells)
            //{
            //    cell = selectedcell;
            //    break;
            //}

            //DataGridViewRow row = cell.OwningRow;
            //string sql = string.Format("delete from KHACHHANG where MAKHACHHANG = '{0}' ", row.Cells["MAKHACHHANG"].Value.ToString());
            //MySqlConnection.Execute(sql);
            //UpdateTable();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataGridViewCell cell = null;
            //    foreach (DataGridViewCell selectedcell in dataGridView_KH.SelectedCells)
            //    {
            //        cell = selectedcell;
            //        break;
            //    }

            //    DataGridViewRow row = cell.OwningRow;

            //    string makh, tenkh, diachi, email, dienthoai, tienno;
            //    makh = txt_MaKH.Text;
            //    tenkh = txt_TenKH.Text;
            //    diachi = txt_DiaChiKH.Text;
            //    email = txt_EmailKH.Text;
            //    dienthoai = txt_SdtKH.Text;
            //    tienno = txt_TienNo.Text;

            //    string sql = string.Format("delete from KHACHHANG where MAKHACHHANG = '{0}' ", row.Cells["MAKHACHHANG"].Value.ToString());
            //    MySqlConnection.Execute(sql);
            //    string sql1 = string.Format("insert into KHACHHANG(MAKHACHHANG,HOTEN,DIACHI,EMAIL,DIENTHOAI,SOTIENNO) values ('{0}','{1}','{2}','{3}','{4}','{5}')", txt_MaKH.Text, txt_TenKH.Text, txt_DiaChiKH.Text, txt_EmailKH.Text, txt_SdtKH.Text, txt_TienNo.Text);
            //    MySqlConnection.Execute(sql1);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Sửa không thành công!");
            //}
        }

        private void dataGridView_KH_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_KH.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_MaKH.Text = row.Cells["MAKHACHHANG"].Value.ToString();
                txt_TenKH.Text = row.Cells["HOTEN"].Value.ToString();
                txt_DiaChiKH.Text = row.Cells["DIACHI"].Value.ToString();
                txt_SdtKH.Text = row.Cells["DIENTHOAI"].Value.ToString();
                txt_EmailKH.Text = row.Cells["EMAIL"].Value.ToString();
                txt_TienNo.Text = row.Cells["SOTIENNO"].Value.ToString();
            }
        }

        private void btn_ThemPN_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // dữ liệu cho chi tiết phiếu nhập
            //    string ctpn = "CHITIETPHIEUNHAP";
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData(ctpn);
            //    int i = tb.Rows.Count + 1;
            //    string mactpt = "CTPT" + i;

            //    string sql = string.Format("insert into CHITIETPHIEUNHAP (MACHITIETPHIEUNHAP,MAPHIEUNHAP, MASACH, SOLUONGNHAP) values ('{0}', '{1}', '{2}' ,'{3}') ", mactpt, txt_MaPhieuNhap.Text, txt_MaSachNhap.Text, txt_SoLuongNhap.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();

            //    // dữ liệu cho phiếu nhập
            //    //string ngaynhap = dTime_NgayNhap.Value.ToString();
            //    //string sql2 = string.Format("insert into PHIEUNHAP (MAPHIEUNHAP, NGAYNHAP) values ('{0}', '{1}') ", txt_MaPhieuNhap.Text, ngaynhap);
            //    //MySqlConnection.Execute(sql2);
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedcell in dataGridView_PhieuNhap.SelectedCells)
            //{
            //    cell = selectedcell;
            //    break;
            //}

            //DataGridViewRow row = cell.OwningRow;
            //string sql = string.Format("delete from CHITIETPHIEUNHAP where MACHITIETPHIEUNHAP = '{0}' ", row.Cells["MACHITIETPHIEUNHAP"].Value.ToString());
            //MySqlConnection.Execute(sql);
            //UpdateTable();
        }

        private void btn_SuaPN_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataGridViewCell cell = null;
            //    foreach (DataGridViewCell selectedcell in dataGridView_PhieuNhap.SelectedCells)
            //    {
            //        cell = selectedcell;
            //        break;
            //    }

            //    DataGridViewRow row = cell.OwningRow;

            //    string maphieunhap,masachnhap,soluongnhap;
            //    maphieunhap = txt_MaPhieuNhap.Text;
            //    masachnhap = txt_MaSachNhap.Text;
            //    soluongnhap = txt_SoLuongNhap.Text;


            //    string sql = string.Format("delete from CHITIETPHIEUNHAP where MACHITIETPHIEUNHAP = '{0}' ", row.Cells["MACHITIETPHIEUNHAP"].Value.ToString());
            //    MySqlConnection.Execute(sql);

            //   // string ctpn = "CHITIETPHIEUNHAP";
            //   // DataTable tb = new DataTable();
            //   // string sql1 = string.Format("select * FROM CHITIETPHIEUNHAP");
            //   // MySqlConnection.Execute(sql1);
            //    //tb = MySqlConnection.LoadData(ctpn);
            //    //int i = tb.Rows.Count + 1;
            //    string str = row.Cells["MACHITIETPHIEUNHAP"].Value.ToString();
            //    string sql2 = string.Format("insert into CHITIETPHIEUNHAP (MACHITIETPHIEUNHAP,MAPHIEUNHAP, MASACH, SOLUONGNHAP) values ('{0}', '{1}', '{2}' ,'{3}') ", str, txt_MaPhieuNhap.Text, txt_MaSachNhap.Text, txt_SoLuongNhap.Text);
            //    MySqlConnection.Execute(sql2);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Sửa không thành công!");
            //}
        }


        private void dataGridView_PhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridView_PhieuNhap.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txt_MaPhieuNhap.Text = row.Cells["MAPHIEUNHAP"].Value.ToString();
                txt_MaSachNhap.Text = row.Cells["MASACH"].Value.ToString();
                txt_SoLuongNhap.Text = row.Cells["SOLUONGNHAP"].Value.ToString();
            }
        }


        private void btn_ThemPT_Click(object sender, EventArgs e)
        {
          
            //try
            //{
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData("PHIEUTHUTIEN");
            //    int i = tb.Rows.Count + 1;
            //    string mapt = "PT" + i;
            //    string ngaythu = dTime_NgayThu.Value.ToString();
            //    string sql = string.Format("insert into PHIEUTHUTIEN (MATHUTIEN,SOTIENTHU,NGAYTHUTIEN, MAKHACHHANG) values ('{0}', '{1}', '{2}' , '{3}') ", mapt, txt_SoTienThu.Text, ngaythu,txt_MaKHThu.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_XoaPT_Click(object sender, EventArgs e)
        {
            
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedcell in dataGridView_PhieuThu.SelectedCells)
            //{
            //    cell = selectedcell;
            //    break;
            //}

            //DataGridViewRow row = cell.OwningRow;
            //string sql = string.Format("delete from PHIEUTHUTIEN where MATHUTIEN = '{0}' ", row.Cells["MATHUTIEN"].Value.ToString());
            //MySqlConnection.Execute(sql);
            //UpdateTable();
        }

        private void btn_SuaPT_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    DataGridViewCell cell = null;
            //    foreach (DataGridViewCell selectedcell in dataGridView_PhieuThu.SelectedCells)
            //    {
            //        cell = selectedcell;
            //        break;
            //    }

            //    DataGridViewRow row = cell.OwningRow;

            //    string maphieuthu, sotienthu, ngaythu, makh;
            //    maphieuthu = txt_MaPhieuThu.Text;
            //    sotienthu = txt_SoTienThu.Text;
            //    ngaythu = dTime_NgayThu.Value.ToString();
            //    makh = txt_MaKHThu.Text;

            //    string sql = string.Format("delete from PHIEUTHUTIEN where MATHUTIEN = '{0}' ", row.Cells["MATHUTIEN"].Value.ToString());
            //    MySqlConnection.Execute(sql);
            //    string sql1 = string.Format("insert into PHIEUTHUTIEN (MATHUTIEN,SOTIENTHU,NGAYTHUTIEN, MAKHACHHANG) values ('{0}', '{1}', '{2}' , '{3}') ", txt_MaPhieuThu.Text, txt_SoTienThu.Text, ngaythu, txt_MaKHThu.Text);
            //    MySqlConnection.Execute(sql1);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Sửa không thành công!");
            //}
        }

        private void dataGridView_PhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedCell in dataGridView_PhieuThu.SelectedCells)
            //{
            //    cell = selectedCell;
            //    break;
            //}
            //if (cell != null)
            //{
            //    DataGridViewRow row = cell.OwningRow;
            //    txt_MaPhieuThu.Text = row.Cells["MATHUTIEN"].Value.ToString();
            //    txt_SoTienThu.Text = row.Cells["SOTIENTHU"].Value.ToString();
            //    txt_MaKHThu.Text = row.Cells["MAKHACHHANG"].Value.ToString();
            //    //dTime_NgayThu.Value = row.Cells["NGAYTHUTIEN"].Value ;
            //}
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
        


            //try
            //{
            //    // dữ liệu cho chi tiết hóa đơn              
            //    DataTable tb = new DataTable();            
            //    tb = MySqlConnection.LoadData("CHITIETHOADON");
            //    int i = tb.Rows.Count + 1;
            //    string cthd = "CTHD" + i;

            //    string sql = string.Format("insert into CHITIETHOADON (MACHITIETHOADON,MAHOADON, MASACH, SOLUONGBAN) values ('{0}', '{1}', '{2}' ,'{3}') ", cthd, txt_MaHD.Text, txt_MaSachLapHD.Text, txt_SoLuongBan.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();

            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedcell in dataGridView_HoaDon.SelectedCells)
            //{
            //    cell = selectedcell;
            //    break;
            //}

            //DataGridViewRow row = cell.OwningRow;
            //string sql = string.Format("delete from CHITIETHOADON where MACHITIETHOADON = '{0}' ", row.Cells["MACHITIETHOADON"].Value.ToString());
            //MySqlConnection.Execute(sql);
            //UpdateTable();
        }

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataGridViewCell cell = null;
            //    foreach (DataGridViewCell selectedcell in dataGridView_HoaDon.SelectedCells)
            //    {
            //        cell = selectedcell;
            //        break;
            //    }

            //    DataGridViewRow row = cell.OwningRow;

            //    string mahoadon, masachlaphd, soluongban;
            //    mahoadon = txt_MaHD.Text;
            //    masachlaphd = txt_MaSachLapHD.Text;
            //    soluongban = txt_SoLuongBan.Text;


            //    string sql = string.Format("delete from CHITIETHOADON where MACHITIETHOADON = '{0}' ", row.Cells["MACHITIETHOADON"].Value.ToString());
            //    MySqlConnection.Execute(sql);


            //    string str = row.Cells["MACHITIETHOADON"].Value.ToString();
            //    string sql2 = string.Format("insert into CHITIETHOADON (MACHITIETHOADON,MAHOADON, MASACH, SOLUONGBAN) values ('{0}', '{1}', '{2}' ,'{3}') ", str, txt_MaHD.Text, txt_MaSachLapHD.Text, txt_SoLuongBan.Text);
            //    MySqlConnection.Execute(sql2);
            //    UpdateTable();               
            //}
            //catch
            //{
            //    MessageBox.Show("Sửa không thành công!");
            //}
        }

        private void dataGridView_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            //DataGridViewCell cell = null;
            //foreach (DataGridViewCell selectedCell in dataGridView_HoaDon.SelectedCells)
            //{
            //    cell = selectedCell;
            //    break;
            //}
            //if (cell != null)
            //{
            //    DataGridViewRow row = cell.OwningRow;
            //    //txt_MaPhieuNhap.Text = row.Cells["MACHITIETHOADON"].Value.ToString();
            //    txt_MaHD.Text = row.Cells["MAHOADON"].Value.ToString();
            //    txt_MaSachLapHD.Text = row.Cells["MASACH"].Value.ToString();
            //    txt_SoLuongBan.Text = row.Cells["SOLUONGBAN"].Value.ToString();
            //}
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap formDN = new FormDangNhap();
            formDN.Show();
        }


        private void comboBox_ThangCongNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int thangcn = 0;
            //switch(comboBox_ThangCongNo.SelectedIndex)
            //{
            //    case 0:
            //        thangcn = 1;
            //        break;
            //    case 1:
            //        thangcn = 2;
            //        break;
            //    case 2:
            //        thangcn = 3;
            //        break;
            //    case 3:
            //        thangcn = 4;
            //        break;
            //    case 4:
            //        thangcn = 5;
            //        break;
            //    case 5:
            //        thangcn = 6;
            //        break;
            //    case 6:
            //        thangcn = 7;
            //        break;
            //    case 7:
            //        thangcn = 8;
            //        break;
            //    case 8:
            //        thangcn = 9;
            //        break;
            //    case 9:
            //        thangcn = 10;
            //        break;
            //    case 10:
            //        thangcn = 11;
            //        break;
            //    case 11:
            //        thangcn = 12;
            //        break;
            //}
            //if (thangcn!=0)
            //{
            //    string thang = thangcn.ToString();
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.Filter_data("BAOCAOCONGNO", "THANG =", thang, "");

            //    dataGridView_CongNo.DataSource = tb;
            //}
        }


        private void comboBox_ThangTon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int thangt = 0;
            //switch (comboBox_ThangTon.SelectedIndex)
            //{
            //    case 0:
            //        thangt = 1;
            //        break;
            //    case 1:
            //        thangt = 2;
            //        break;
            //    case 2:
            //        thangt = 3;
            //        break;
            //    case 3:
            //        thangt = 4;
            //        break;
            //    case 4:
            //        thangt = 5;
            //        break;
            //    case 5:
            //        thangt = 6;
            //        break;
            //    case 6:
            //        thangt = 7;
            //        break;
            //    case 7:
            //        thangt = 8;
            //        break;
            //    case 8:
            //        thangt = 9;
            //        break;
            //    case 9:
            //        thangt = 10;
            //        break;
            //    case 10:
            //        thangt = 11;
            //        break;
            //    case 11:
            //        thangt = 12;
            //        break;
            //}
            //if (thangt != 0)
            //{
            //    string thang = thangt.ToString();
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.Filter_data("BAOCAOTON", "THANG =", thang, "");

            //    dataGridView_Ton.DataSource = tb;
            //}
        }

        private void txt_MaSachTK_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyData==Keys.Enter)
            //{
            //    string mstk = "'"+ txt_MaSachTK.Text +"'";
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.Filter_data("SACH", "MASACH =" , mstk,"");

            //    dataGridView_TK.DataSource = tb;    
            //}
        }

        private void txt_TenSachTK_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    string tstk = "'" + txt_TenSachTK.Text + "'";
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.Filter_data("SACH", "TENSACH =", tstk, "");

            //    dataGridView_TK.DataSource = tb;
            //}   
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDMK formDMK = new FormDMK();
            formDMK.Show();
        }

        private void buttonX30_Click(object sender, EventArgs e)
        {
            //string msb = "Đã thay đổi ";
            //if(txt_SLNhapItNhat.Text!="")
            //{
            //    string sql = string.Format("update THAMSO set SOLUONGNHAPITNHAT = '{0}'  ",txt_SLNhapItNhat.Text);
            //    MySqlConnection.Execute(sql);
            //    msb += "số lượng nhập ít nhất, ";
            //}
            //if (txt_TienNoToiDa.Text != "")
            //{
            //    string sql = string.Format("update THAMSO set SOTIENNOTOIDA = '{0}'  ", txt_TienNoToiDa.Text);
            //    MySqlConnection.Execute(sql);
            //    msb += "số tiền nợ tối đa, ";
            //}
            //if (txt_TonToiDaTruocKhiNhap.Text != "")
            //{
            //    string sql = string.Format("update THAMSO set SOLUONGTONTOIDATRUOCNHAP = '{0}'  ", txt_TonToiDaTruocKhiNhap.Text);
            //    MySqlConnection.Execute(sql);
            //    msb += "số lượng tồn tối đa trước nhập, ";
            //}
            //if (txt_TonToiThieuSauBan.Text != "")
            //{
            //    string sql = string.Format("update THAMSO set SOLUONGTONTOITHIEUSAUBAN = '{0}'  ", txt_TonToiThieuSauBan.Text);
            //    MySqlConnection.Execute(sql);
            //    msb += "số lượng tồn tối thiểu sau bán, ";
            //}
            //if (check_SuDungQD4.Checked)
            //{
            //    string co = "true";
            //    string sql = string.Format("update THAMSO set SUDUNGQUIDINH4 = '{0}'  ", co);
            //    MySqlConnection.Execute(sql);
            //    msb += " có sử dụng qui định 4.";
            //}
            //else
            //{
            //    string khong = "false";
            //    string sql = string.Format("update THAMSO set SUDUNGQUIDINH4 = '{0}'  ", khong);
            //    MySqlConnection.Execute(sql);
            //    msb += " không sử dụng qui định 4.";
            //}

            //MessageBox.Show(msb);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_ThemPhieuNhap_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData("PHIEUNHAP");
            //    int i = tb.Rows.Count + 1;

            //    string tpn = "PN" + i;
            //    string sql = string.Format("insert into PHIEUNHAP (MAPHIEUNHAP,NGAYNHAP) values ('{0}', '{1}') ", tpn, dTime_NgayNhap.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_ThemHoaDonTQ_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DataTable tb = new DataTable();
            //    tb = MySqlConnection.LoadData("HOADON");
            //    int i = tb.Rows.Count + 1;
            //    string hd = "HD" + i;

            //    string sql = string.Format("insert into HOADON (MAHOADON,MAKHACHHANG,NGAYLAPHOADON) values ('{0}', '{1}', '{2}') ", hd, txt_MaKHLapHD.Text, dTime_LapHD.Text);
            //    MySqlConnection.Execute(sql);
            //    UpdateTable();
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm dữ liệu không thành công!");
            //}
        }

        private void btn_InBaoCao_Click(object sender, EventArgs e)
        {

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

        private void PhieuThuTab_Click(object sender, EventArgs e)
        {
            
            
        }

   
        private void btnThem_Click(object sender, EventArgs e)
        {
            //int index = dgvPhieuThu.CurrentCell.RowIndex;

            //string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            //float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            //string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            //DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            //PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            //phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            //phieuThuTienDto.SoTienThu = soTienThu;
            //phieuThuTienDto.MaKhachHang = maKhachHang;
            //phieuThuTienDto.NgayThu = ngayThu;

            //if (_phieuThuTienBll.InsertPhieuThuTien(phieuThuTienDto) == 1)
            //{
            //    MessageBox.Show("Thêm phiếu thu tiền thành công!");

            //    LoadDataPhieuThu();
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu thu!", "Lỗi!");
            //}

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //int index = dgvPhieuThu.CurrentCell.RowIndex;

            //string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            //float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            //string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            //DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            //PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            //phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            //phieuThuTienDto.SoTienThu = soTienThu;
            //phieuThuTienDto.MaKhachHang = maKhachHang;
            //phieuThuTienDto.NgayThu = ngayThu;

            //if (_phieuThuTienBll.UpdatePhieuThuTien(phieuThuTienDto) == 1)
            //{
            //    MessageBox.Show("Cập nhật phiếu thu tiền thành công!");

            //    LoadDataPhieuThu();
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi trường nhập vào hoặc trùng mã phiếu thu không tồn tại!", "Lỗi!");
            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int index = dgvPhieuThu.CurrentCell.RowIndex;

            //string maPhieuThu = dgvPhieuThu.Rows[index].Cells[0].Value.ToString();
            //float soTienThu = float.Parse(dgvPhieuThu.Rows[index].Cells[1].Value.ToString());
            //string maKhachHang = dgvPhieuThu.Rows[index].Cells[2].Value.ToString();
            //DateTime ngayThu = DateTime.Parse(dgvPhieuThu.Rows[index].Cells[3].Value.ToString());

            //PhieuThuTienDTO phieuThuTienDto = new PhieuThuTienDTO();
            //phieuThuTienDto.MaPhieuThuTien = maPhieuThu;
            //phieuThuTienDto.SoTienThu = soTienThu;
            //phieuThuTienDto.MaKhachHang = maKhachHang;
            //phieuThuTienDto.NgayThu = ngayThu;

            //if (_phieuThuTienBll.DeleteByMaPhieuThuTien(phieuThuTienDto) == 1)
            //{
            //    MessageBox.Show("Xóa phiếu thu tiền thành công!");

            //    LoadDataPhieuThu();
            //}
            //else
            //{
            //    MessageBox.Show("Có lỗi xảy ra hoặc mã phiếu thu không tồn tại!", "Lỗi!");
            //}
        }
    }
}
