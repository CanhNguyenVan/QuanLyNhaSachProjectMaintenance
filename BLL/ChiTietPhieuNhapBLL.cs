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
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL chiTietPhieuNhapDAL = new ChiTietPhieuNhapDAL();

        public DataTable SelectAll()
        {
            return chiTietPhieuNhapDAL.SelectAll();
        }

        public int InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return chiTietPhieuNhapDAL.InsertChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }

        public int UpdateChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return chiTietPhieuNhapDAL.UpdateChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }

        public int DeleteByMaChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return chiTietPhieuNhapDAL.DeleteByMaChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }
    }
}
