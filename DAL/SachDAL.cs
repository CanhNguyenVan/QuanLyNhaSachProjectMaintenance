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
        public List<SachDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<SachDTO> list = new List<SachDTO>();

                dataTable = connect.GetData("Sach_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    SachDTO sachDTO = new SachDTO();
                    sachDTO.MaSach = dataTable.Rows[i].ItemArray[0].ToString();
                    sachDTO.TenSach = dataTable.Rows[i].ItemArray[1].ToString();
                    sachDTO.TheLoai = dataTable.Rows[i].ItemArray[2].ToString();
                    sachDTO.TacGia = dataTable.Rows[i].ItemArray[3].ToString();
                    sachDTO.NamSanXuat = int.Parse(dataTable.Rows[i].ItemArray[4].ToString());
                    sachDTO.SoLuongTon = int.Parse(dataTable.Rows[i].ItemArray[5].ToString());
                    sachDTO.DonGiaBan = float.Parse(dataTable.Rows[i].ItemArray[4].ToString());

                    list.Add(sachDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm một cuốn sách vào danh sách Sách
        public void InsertSach(SachDTO sachDTO)
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

            connect.ExcuteNonQuery("Sach_Insert", name, values, param);
        }

        //Sửa đổi thông tin của sách
        public void UpdateSach(SachDTO sachDTO)
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

            connect.ExcuteNonQuery("Sach_Update", name, values, param);
        }

        //Xóa sách trong danh sách Sách theo Mã Sách
        public void DeleteSachByMaSach(SachDTO sachDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaSach";
            values[0] = sachDTO.MaSach;

            connect.ExcuteNonQuery("Sach_DeleteByMaSach", name, values, param);
        }

        //Xóa sách trong danh sách Sách theo Tên Sách
        public void DeleteSachByTenSach(SachDTO sachDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@TenSach";
            values[0] = sachDTO.TenSach;

            connect.ExcuteNonQuery("Sach_DeleteByTenSach", name, values, param);
        }
    }
}
