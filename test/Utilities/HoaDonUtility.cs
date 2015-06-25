using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DevExpress.XtraPrinting.Native;
using DTO;

namespace test.Utilities
{
    public static class HoaDonUtility
    {

        private static string _maHoaDonPrefix = "MHD";

        private static string _maChiTietHoaDonPrefix = "MCTHD";

        public static string PhatSinhMaHoaDon()
        {
            HoaDonBLL hoaDonBll = new HoaDonBLL();

            var hoaDonList = hoaDonBll.SelectAll();

            if (hoaDonList.IsEmpty())
            {
                return _maHoaDonPrefix + 1;
            }

            List<int> maHoaDonList = new List<int>();

            foreach (HoaDonDTO hoaDonDto in hoaDonList)
            {
                maHoaDonList.Add(int.Parse(hoaDonDto.MaHoaDon.Replace(_maHoaDonPrefix, "")));
            }
            
            return _maHoaDonPrefix + (maHoaDonList.Max() + 1);

        }

        public static string PhatSinhChiTietMaHoaDon()
        {
            ChiTietHoaDonBLL chiTietHoaDonBll = new ChiTietHoaDonBLL();

            var chiTietHoaDonList = chiTietHoaDonBll.SelectAll();

            if (chiTietHoaDonList.IsEmpty())
            {
                return _maChiTietHoaDonPrefix + 1;
            }


            List<int> maChiTietHoaDonList = new List<int>();

            foreach (ChiTietHoaDonDTO chiTietHoaDonDto in chiTietHoaDonList)
            {
                maChiTietHoaDonList.Add(int.Parse(chiTietHoaDonDto.MaChiTietHoaDon.Replace(_maChiTietHoaDonPrefix, "")));
            }

            return _maChiTietHoaDonPrefix + (maChiTietHoaDonList.Max()  + 1);

        }

    }
}
