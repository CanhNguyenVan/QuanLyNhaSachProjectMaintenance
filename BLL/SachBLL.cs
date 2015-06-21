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
        public List<SachDTO> SelectAll()
        {
            return sachDAL.SelectAll();
        }

        //Thêm một cuốn sách vào danh sách Sách
        public void InsertSach(SachDTO sachDTO)
        {
            sachDAL.InsertSach(sachDTO);
        }

        //Sửa đổi thông tin của sách
        public void UpdateSach(SachDTO sachDTO)
        {
            sachDAL.UpdateSach(sachDTO);
        }

        //Xóa sách trong danh sách Sách theo Mã Sách
        public void DeleteSachByMaSach(SachDTO sachDTO)
        {
            sachDAL.DeleteSachByMaSach(sachDTO);
        }

        //Xóa sách trong danh sách Sách theo Tên Sách
        public void DeleteSachByTenSach(SachDTO sachDTO)
        {
            sachDAL.DeleteSachByTenSach(sachDTO);
        }
    }
}
