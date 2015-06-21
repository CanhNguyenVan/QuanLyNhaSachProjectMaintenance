using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
    public class BaoCaoCongNoDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Tao phuong thuc OnPropertyChanged để nâng cao event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maBaoCaoCongNo;

        public string MaBaoCaoCongNo
        {
            get { return _maBaoCaoCongNo; }
            set
            {
                if (value != _maBaoCaoCongNo)
                {
                    _maBaoCaoCongNo = value;
                    OnPropertyChanged("MBCCN");
                }
            }
        }

        private int _thang;

        public int Thang
        {
            get { return _thang; }
            set
            {
                if (_thang > 0 && _thang < 13)
                    _thang = value;
                else
                    throw new ArgumentException(Constants.DataExceptionGeneral);
            }
        }
        private string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        private float _noDau;

        public float NoDau
        {
            get { return _noDau; }
            set { _noDau = value; }
        }
        private float _noPhatSinh;

        public float NoPhatSinh
        {
            get { return _noPhatSinh; }
            set { _noPhatSinh = value; }
        }
        private float _noCuoi;

        public float NoCuoi
        {
            get { return _noCuoi; }
            set { _noCuoi = value; }
        }
    }
}
