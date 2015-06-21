using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Tạo Phương thức OnPropertyChanged để nâng cao event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maChiTietHoaDon;

        public string MaChiTietHoaDon
        {
            get { return _maChiTietHoaDon; }
            set
            {
                if (value != _maChiTietHoaDon)
                {
                    _maChiTietHoaDon = value;
                    OnPropertyChanged("MCTHD");
                }
            }
        }
        private string _maHoaDon;

        public string MaHoaDon
        {
            get { return _maHoaDon; }
            set { _maHoaDon = value; }
        }
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private int _soLuongBan;

        public int SoLuongBan
        {
            get { return _soLuongBan; }
            set { _soLuongBan = value; }
        }
    }
}
