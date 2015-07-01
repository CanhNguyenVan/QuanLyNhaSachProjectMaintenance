using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSoDTO
    {
        private int _maThamSo;

        public int MaThamSo
        {
            get { return _maThamSo; }
            set { _maThamSo = value; }
        }
        private int _soLuongNhapToiThieu;

        public int SoLuongNhapToiThieu
        {
            get { return _soLuongNhapToiThieu; }
            set { _soLuongNhapToiThieu = value; }
        }
        private int _soLuongTonToiDaTruocKhiNhap;

        public int SoLuongTonToiDaTruocKhiNhap
        {
            get { return _soLuongTonToiDaTruocKhiNhap; }
            set { _soLuongTonToiDaTruocKhiNhap = value; }
        }
        private int _soLuongTonToiThieuSauKhiBan;

        public int SoLuongTonToiThieuSauKhiBan
        {
            get { return _soLuongTonToiThieuSauKhiBan; }
            set { _soLuongTonToiThieuSauKhiBan = value; }
        }
        private int _tienNoToiDa;

        public int TienNoToiDa
        {
            get { return _tienNoToiDa; }
            set { _tienNoToiDa = value; }
        }
    }
}
