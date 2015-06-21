using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();

        //Hiển thị danh sách khách hàng lên màn hình
        public List<KhachHangDTO> SelectAll()
        {
            return khachHangDAL.SelectAll();
        }

        //Thêm mới một khách hàng
        public void InsertKhachHang(KhachHangDTO khachHangDTO)
        {
            khachHangDAL.InsertKhachHang(khachHangDTO);
        }

        //Sửa thông tin một khách hàng
        public void UpdateKhachHang(KhachHangDTO khachHangDTO)
        {
            khachHangDAL.UpdateKhachHang(khachHangDTO);
        }

        //Xóa một khách hàng theo MaKhachHang
        public void DeleteByMaKhachHang(KhachHangDTO khachHangDTO)
        {
            khachHangDAL.DeleteByMaKhachHang(khachHangDTO);
        }
    }
}
