using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BLL
{
    public class SachBLL
    {
        SachDAL sachDAL = new SachDAL();

        //Chức năng hiển thị danh sách Sách trong database lên màn hình
        public DataTable SelectAll()
        {
            return sachDAL.SelectAll();
        }

        //Thêm một cuốn sách vào danh sách Sách
        public int InsertSach(SachDTO sachDTO)
        {
            return sachDAL.InsertSach(sachDTO);
        }

        //Sửa đổi thông tin của sách
        public int UpdateSach(SachDTO sachDTO)
        {
            return sachDAL.UpdateSach(sachDTO);
        }

        //Xóa sách trong danh sách Sách theo Mã Sách
        public int DeleteSachByMaSach(SachDTO sachDTO)
        {
            return sachDAL.DeleteSachByMaSach(sachDTO);
        }

        //Xóa sách trong danh sách Sách theo Tên Sách
        public int DeleteSachByTenSach(SachDTO sachDTO)
        {
            return sachDAL.DeleteSachByTenSach(sachDTO);
        }
    }
}
