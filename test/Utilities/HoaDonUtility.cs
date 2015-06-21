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

        public static string PhatSinhMaHoaDon()
        {
            HoaDonBLL hoaDonBll = new HoaDonBLL();

            var hoaDonList = hoaDonBll.SelectAll();

            if (hoaDonList.IsEmpty())
            {
                return _maHoaDonPrefix + 1;
            }
            var s = 2;

            List<int> maHoaDonList = new List<int>();

            foreach (HoaDonDTO hoaDonDto in hoaDonList)
            {
                maHoaDonList.Add(int.Parse(hoaDonDto.MaHoaDon.Replace(_maHoaDonPrefix, "")));
            }

            var max = maHoaDonList.Max();

            s = max + 1;

            return _maHoaDonPrefix + s;

        }

    }
}
