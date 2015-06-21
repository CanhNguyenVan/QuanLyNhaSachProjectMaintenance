using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace DTO
{
    public class PhieuThuTienDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        //Tạo phuong thức OnPropertyChanged để nâng cao event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maPhieuThuTien;

        public string MaPhieuThuTien
        {
            get { return _maPhieuThuTien; }
            set
            {
                if (value != _maPhieuThuTien)
                {
                    _maPhieuThuTien = value;
                    OnPropertyChanged("MPTT");
                }
            }
        }
        private float _soTienThu;

        public float SoTienThu
        {
            get { return _soTienThu; }
            set { _soTienThu = value; }
        }
        private string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        private DateTime? _ngayThu;

        public DateTime? NgayThu
        {
            get
            {
                if (_ngayThu == SqlDateTime.MinValue.Value)
                    _ngayThu = null;
                return _ngayThu;
            }
            set { _ngayThu = value; }
        }
    }
}
