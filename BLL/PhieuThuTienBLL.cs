using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuThuTienBLL
    {
        PhieuThuTienDAL phieuThuTienDAL = new PhieuThuTienDAL();

        //Hiển thị danh sách phiếu thu tiền lên màn hình
        public List<PhieuThuTienDTO> SelectAll()
        {
            return phieuThuTienDAL.SelectAll();
        }

        //Thêm mới một phiếu thu tiền
        public void InsertPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            phieuThuTienDAL.InsertPhieuThuTien(phieuThuTienDTO);
        }

        //Sửa một phiếu thu tiền
        public void UpdatePhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            phieuThuTienDAL.UpdatePhieuThuTien(phieuThuTienDTO);
        }

        //Xóa một phiếu thu tiền theo mà phiếu thu tiền
        public void DeleteByMaPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            phieuThuTienDAL.DeleteByMaPhieuThuTien(phieuThuTienDTO);
        }
    }
}
