using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();

        public List<ChiTietPhieuNhapDTO> SelectAll()
        {
            return chiTietPhieuNhapDAL.SelectAll();
        }

        public void InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            chiTietPhieuNhapDAL.InsertChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }

        public void UpdateChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            chiTietPhieuNhapDAL.UpdateChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }

        public void DeleteByMaChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            chiTietPhieuNhapDAL.DeleteByMaChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }
    }
}
