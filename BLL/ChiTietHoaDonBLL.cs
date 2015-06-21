using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        ChiTietHoaDonDAL chiTietHoaDonDAL = new ChiTietHoaDonDAL();

        public List<ChiTietHoaDonDTO> SelectAll()
        {
            return chiTietHoaDonDAL.SelectAll();
        }

        public void InsertChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            chiTietHoaDonDAL.InsertChiTietHoaDon(chiTietHoaDonDTO);
        }

        public void UpdateChiTietPhieuNhap(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            chiTietHoaDonDAL.UpdateChiTietHoaDon(chiTietHoaDonDTO);
        }

        public void DeleteByMaChiTietPhieuNhap(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            chiTietHoaDonDAL.DeleteByMaChiTietsHoaDon(chiTietHoaDonDTO);
        }
    }
}
