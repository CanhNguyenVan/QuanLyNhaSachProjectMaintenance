using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();

        //Hiển thị danh sách hóa đơn lên màn hình
        public List<HoaDonDTO> SelectAll()
        {
            return hoaDonDAL.SelectAll();
        }

        //thêm mới một hóa đơn
        public void InsertHoaDon(HoaDonDTO hoaDonDTO)
        {
            hoaDonDAL.InsertHoaDon(hoaDonDTO);
        }

        //Sửa thông tin một hóa đơn
        public void UpdateHoaDon(HoaDonDTO hoaDonDTO)
        {
            hoaDonDAL.UpdateHoaDon(hoaDonDTO);
        }

        //Xóa một hóa đơn
        public void DeleteByMaHoaDon(HoaDonDTO hoaDonDTO)
        {
            hoaDonDAL.DeleteByMaHoaDon(hoaDonDTO);
        }
    }
}
