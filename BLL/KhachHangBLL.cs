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
    public class KhachHangBLL
    {
        KhachHangDAL khachHangDAL = new KhachHangDAL();

        //Hiển thị danh sách khách hàng lên màn hình
        public DataTable SelectAll()
        {
            return khachHangDAL.SelectAll();
        }

        //Thêm mới một khách hàng
        public int InsertKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.InsertKhachHang(khachHangDTO);
        }

        //Sửa thông tin một khách hàng
        public int UpdateKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.UpdateKhachHang(khachHangDTO);
        }

        //Xóa một khách hàng theo MaKhachHang
        public int DeleteByMaKhachHang(KhachHangDTO khachHangDTO)
        {
            return khachHangDAL.DeleteByMaKhachHang(khachHangDTO);
        }
    }
}
