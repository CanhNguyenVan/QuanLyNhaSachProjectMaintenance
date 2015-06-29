using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class PhieuThuTienBLL
    {
        PhieuThuTienDAL phieuThuTienDAL = new PhieuThuTienDAL();

        //Hiển thị danh sách phiếu thu tiền lên màn hình
        public DataTable SelectAll()
        {
            return phieuThuTienDAL.SelectAll();
        }

        //Thêm mới một phiếu thu tiền
        public int InsertPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            return phieuThuTienDAL.InsertPhieuThuTien(phieuThuTienDTO);
        }

        //Sửa một phiếu thu tiền
        public int UpdatePhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            return phieuThuTienDAL.UpdatePhieuThuTien(phieuThuTienDTO);
        }

        //Xóa một phiếu thu tiền theo mà phiếu thu tiền
        public int DeleteByMaPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            return phieuThuTienDAL.DeleteByMaPhieuThuTien(phieuThuTienDTO);
        }
    }
}
