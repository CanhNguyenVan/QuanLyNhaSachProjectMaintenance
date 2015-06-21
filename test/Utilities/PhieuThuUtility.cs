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
    public static class PhieuThuUtility
    {
        private static string _maPhieuThuPrefix = "MPT";

        public static string PhatSinhMaPhieuThu()
        {
            PhieuThuTienBLL phieuThuBll = new PhieuThuTienBLL();

            var phieuThuList = phieuThuBll.SelectAll();

            if (phieuThuList.IsEmpty())
            {
                return _maPhieuThuPrefix + "1";
            }

            var s = 2;

            List<int> maPhieuThuList = new List<int>();

            foreach (PhieuThuTienDTO phieuThuTienDto in phieuThuList)
            {
                maPhieuThuList.Add(int.Parse(phieuThuTienDto.MaPhieuThuTien.Replace(_maPhieuThuPrefix, "")));
            }

            var max  = maPhieuThuList.Max();

            s = max + 1;
            
            return _maPhieuThuPrefix + s;
        }

    }
}
