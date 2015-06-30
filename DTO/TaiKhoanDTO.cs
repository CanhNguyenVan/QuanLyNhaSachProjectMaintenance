using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string _maTaiKhoan;

        public string MaTaiKhoan
        {
            get { return _maTaiKhoan; }
            set { _maTaiKhoan = value; }
        }
        private string _tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return _tenTaiKhoan; }
            set { _tenTaiKhoan = value; }
        }
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }
        private string _loaiTaiKhoan;

        public string LoaiTaiKhoan
        {
            get { return _loaiTaiKhoan; }
            set { _loaiTaiKhoan = value; }
        }
    }
}
