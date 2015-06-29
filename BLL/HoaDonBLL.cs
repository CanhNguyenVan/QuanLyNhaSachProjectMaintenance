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
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();

        //Hiển thị danh sách hóa đơn lên màn hình
        public DataTable SelectAll()
        {
            return hoaDonDAL.SelectAll();
        }

        //thêm mới một hóa đơn
        public int InsertHoaDon(HoaDonDTO hoaDonDTO)
        {
            return hoaDonDAL.InsertHoaDon(hoaDonDTO);
        }

        //Sửa thông tin một hóa đơn
        public int UpdateHoaDon(HoaDonDTO hoaDonDTO)
        {
            return hoaDonDAL.UpdateHoaDon(hoaDonDTO);
        }

        //Xóa một hóa đơn
        public int DeleteByMaHoaDon(HoaDonDTO hoaDonDTO)
        {
            return hoaDonDAL.DeleteByMaHoaDon(hoaDonDTO);
        }
    }
}
