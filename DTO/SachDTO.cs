using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
    public class SachDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Tạo phương thức OnPropertyChanged để nâng cao cho event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set
            {
                if (value != _maSach)
                {
                    _maSach = value;
                    OnPropertyChanged("MS");
                }
            }
        }
        private string _tenSach;

        public string TenSach
        {
            get { return _tenSach; }
            set { _tenSach = value; }
        }
        private string _theLoai;

        public string TheLoai
        {
            get { return _theLoai; }
            set { _theLoai = value; }
        }
        private string _tacGia;

        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        private int _namSanXuat;

        public int NamSanXuat
        {
            get { return _namSanXuat; }
            set { _namSanXuat = value; }
        }
        private int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }
        private float _donGiaBan;

        public float DonGiaBan
        {
            get { return _donGiaBan; }
            set { _donGiaBan = value; }
        }
    }
}
