using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class SachDAL
    {
        private DataConnecter connect;

        //Constructor
        public SachDAL()
        {
            connect = new DataConnecter();
        }

        //Chức năng hiển thị danh sách Sách trong database lên màn hình
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("Sach_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm một cuốn sách vào danh sách Sách
        public int InsertSach(SachDTO sachDTO)
        {
            int param = 7;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaSach";
            name[1] = "@TenSach";
            name[2] = "@TheLoai";
            name[3] = "@TacGia";
            name[4] = "@NamXuatBan";
            name[5] = "@SoLuongTon";
            name[6] = "@DonGiaBan";

            values[0] = sachDTO.MaSach;
            values[1] = sachDTO.TenSach;
            values[2] = sachDTO.TheLoai;
            values[3] = sachDTO.TacGia;
            values[4] = sachDTO.NamSanXuat;
            values[5] = sachDTO.SoLuongTon;
            values[6] = sachDTO.DonGiaBan;

            return connect.ExcuteNonQuery("Sach_Insert", name, values, param);
        }

        //Sửa đổi thông tin của sách
        public int UpdateSach(SachDTO sachDTO)
        {
            int param = 7;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaSach";
            name[1] = "@TenSach";
            name[2] = "@TheLoai";
            name[3] = "@TacGia";
            name[4] = "@NamXuatBan";
            name[5] = "@SoLuongTon";
            name[6] = "@DonGiaBan";

            values[0] = sachDTO.MaSach;
            values[1] = sachDTO.TenSach;
            values[2] = sachDTO.TheLoai;
            values[3] = sachDTO.TacGia;
            values[4] = sachDTO.NamSanXuat;
            values[5] = sachDTO.SoLuongTon;
            values[6] = sachDTO.DonGiaBan;

            return connect.ExcuteNonQuery("Sach_Update", name, values, param);
        }

        //Xóa sách trong danh sách Sách theo Mã Sách
        public int DeleteSachByMaSach(SachDTO sachDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaSach";
            values[0] = sachDTO.MaSach;

            return connect.ExcuteNonQuery("Sach_DeleteByMaSach", name, values, param);
        }

        //Xóa sách trong danh sách Sách theo Tên Sách
        public int DeleteSachByTenSach(SachDTO sachDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@TenSach";
            values[0] = sachDTO.TenSach;

            return connect.ExcuteNonQuery("Sach_DeleteByTenSach", name, values, param);
        }
    }
}
