using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO : INotifyPropertyChanged
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

        private string _maChiTietPhieuNhap;

        public string MaChiTietPhieuNhap
        {
            get { return _maChiTietPhieuNhap; }
            set
            {
                if (value != _maChiTietPhieuNhap)
                {
                    _maChiTietPhieuNhap = value;
                    OnPropertyChanged("MCTPN");
                }
            }
        }
        private string _maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _maPhieuNhap; }
            set { _maPhieuNhap = value; }
        }
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private int _soLuongNhap;

        public int SoLuongNhap
        {
            get { return _soLuongNhap; }
            set { _soLuongNhap = value; }
        }
        private float _donGiaNhap;

        public float DonGiaNhap
        {
            get { return _donGiaNhap; }
            set { _donGiaNhap = value; }
        }
    }
}
