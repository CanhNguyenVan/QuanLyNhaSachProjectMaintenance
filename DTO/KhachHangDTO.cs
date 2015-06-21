using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
    public class KhachHangDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set
            {
                if (value != _maKhachHang)
                {
                    _maKhachHang = value;
                    OnPropertyChanged("MKH");
                }
            }
        }
        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private int _dienThoai;

        public int DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private float _soTienNo;

        public float SoTienNo
        {
            get { return _soTienNo; }
            set { _soTienNo = value; }
        }
    }
}
