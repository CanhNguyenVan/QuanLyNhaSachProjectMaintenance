using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DTO
{
    public class BaoCaoTonDTO : INotifyPropertyChanged
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

        private string _maBaoCaoTon;

        public string MaBaoCaoTon
        {
            get { return _maBaoCaoTon; }
            set
            {
                if (value != _maBaoCaoTon)
                {
                    _maBaoCaoTon = value;
                    OnPropertyChanged("MBCT");
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
        private string _maSach;

        public string MaSach
        {
            get { return _maSach; }
            set { _maSach = value; }
        }
        private int _tonDau;

        public int TonDau
        {
            get { return _tonDau; }
            set { _tonDau = value; }
        }
        private int _tonPhatSinh;

        public int TonPhatSinh
        {
            get { return _tonPhatSinh; }
            set { _tonPhatSinh = value; }
        }
        private int _tonCuoi;

        public int TonCuoi
        {
            get { return _tonCuoi; }
            set { _tonCuoi = value; }
        }
    }
}
