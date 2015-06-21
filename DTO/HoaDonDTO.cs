using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlTypes;

namespace DTO
{
    public class HoaDonDTO : INotifyPropertyChanged
    {
        //Implement interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Tạo phương thức OnPropertyChanged để nâng cao event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _maHoaDon;

        public string MaHoaDon
        {
            get { return _maHoaDon; }
            set
            {
                if (value != _maHoaDon)
                {
                    _maHoaDon = value;
                    OnPropertyChanged("MHD");
                }
            }
        }
        private string _maKhachHang;

        public string MaKhachHang
        {
            get { return _maKhachHang; }
            set { _maKhachHang = value; }
        }
        private DateTime? _ngayLap;

        public DateTime? NgayLap
        {
            get {
                if (_ngayLap == SqlDateTime.MinValue.Value)
                    _ngayLap = null;
                return _ngayLap; }
            set { _ngayLap = value; }
        }
    }
}
