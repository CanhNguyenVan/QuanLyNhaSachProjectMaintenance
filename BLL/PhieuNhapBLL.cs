using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL phieuNhapDAL = new PhieuNhapDAL();

        //Hiển thị danh sách các phiếu nhập lên màn hình
        public List<PhieuNhapDTO> SelectAll()
        {
            return phieuNhapDAL.SelectAll();
        }

        //Thêm mới một phiếu nhập
        public void InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            phieuNhapDAL.InsertPhieuNhap(phieuNhapDTO);
        }

        //Sửa thông tin một phiếu nhập
        public void UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            phieuNhapDAL.UpdatePhieuNhap(phieuNhapDTO);
        }

        //Xóa một phiếu nhập theo MaPhieuNhap
        public void DeleteByMaPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            phieuNhapDAL.DeleteByMaPhieuNhap(phieuNhapDTO);
        }
    }
}
