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
    public class PhieuNhapBLL
    {
        PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();

        //Hiển thị danh sách các phiếu nhập lên màn hình
        public DataTable SelectAll()
        {
            return phieuNhapDAL.SelectAll();
        }

        //Thêm mới một phiếu nhập
        public int InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return phieuNhapDAL.InsertPhieuNhap(phieuNhapDTO);
        }

        //Sửa thông tin một phiếu nhập
        public int UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return phieuNhapDAL.UpdatePhieuNhap(phieuNhapDTO);
        }

        //Xóa một phiếu nhập theo MaPhieuNhap
        public int DeleteByMaPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return phieuNhapDAL.DeleteByMaPhieuNhap(phieuNhapDTO);
        }
    }
}
