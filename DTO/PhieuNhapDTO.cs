using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace DTO
{
    public class PhieuNhapDTO : INotifyPropertyChanged
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

        private string _maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _maPhieuNhap; }
            set
            {
                if (value != _maPhieuNhap)
                {
                    _maPhieuNhap = value;
                    OnPropertyChanged("MPN");
                }
            }
        }
        private DateTime? _ngayNhap;

        public DateTime? NgayNhap
        {
            get
            {
                if (_ngayNhap == SqlDateTime.MinValue.Value)
                    _ngayNhap = null;
                return _ngayNhap;
            }
            set { _ngayNhap = value; }
        }
    }
}
