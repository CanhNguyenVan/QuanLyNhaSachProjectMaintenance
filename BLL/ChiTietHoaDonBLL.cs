using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public DataTable SelectAll()
        {
            return chiTietHoaDonDAL.SelectAll();
        }

        public int InsertChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            return chiTietHoaDonDAL.InsertChiTietHoaDon(chiTietHoaDonDTO);
        }

        public int UpdateChiTietPhieuNhap(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            return chiTietHoaDonDAL.UpdateChiTietHoaDon(chiTietHoaDonDTO);
        }

        public int DeleteByMaChiTietPhieuNhap(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            return chiTietHoaDonDAL.DeleteByMaChiTietsHoaDon(chiTietHoaDonDTO);
        }
    }
}
