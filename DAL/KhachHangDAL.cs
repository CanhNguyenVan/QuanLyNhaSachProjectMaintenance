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
    public class KhachHangDAL
    {
        private DataConnecter connect;

        //Constructor
        public KhachHangDAL()
        {
            connect = new DataConnecter();
        }

        //Hiển thị danh sách khách hàng lên màn hình
        public List<KhachHangDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<KhachHangDTO> list = new List<KhachHangDTO>();

                dataTable = connect.GetData("KhachHang_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    KhachHangDTO khachHangDTO = new KhachHangDTO();
                    khachHangDTO.MaKhachHang = dataTable.Rows[i].ItemArray[0].ToString();
                    khachHangDTO.HoTen = dataTable.Rows[i].ItemArray[1].ToString();
                    khachHangDTO.DiaChi = dataTable.Rows[i].ItemArray[2].ToString();
                    khachHangDTO.DienThoai = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    khachHangDTO.Email = dataTable.Rows[i].ItemArray[4].ToString();
                    khachHangDTO.SoTienNo = float.Parse(dataTable.Rows[i].ItemArray[5].ToString());

                    list.Add(khachHangDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm mới một khách hàng
        public void InsertKhachHang(KhachHangDTO khachHangDTO)
        {
            int param = 6;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaKhacHang";
            name[1] = "@HoTen";
            name[2] = "@DiaChi";
            name[3] = "@DienThoai";
            name[4] = "@Email";
            name[5] = "@SoTienNo";

            values[0] = khachHangDTO.MaKhachHang;
            values[1] = khachHangDTO.HoTen;
            values[2] = khachHangDTO.DiaChi;
            values[3] = khachHangDTO.DienThoai;
            values[4] = khachHangDTO.Email;
            values[5] = khachHangDTO.SoTienNo;

            connect.ExcuteNonQuery("KhachHang_Insert", name, values, param);
        }

        //Sửa thông tin một khách hàng
        public void UpdateKhachHang(KhachHangDTO khachHangDTO)
        {
            int param = 6;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaKhacHang";
            name[1] = "@HoTen";
            name[2] = "@DiaChi";
            name[3] = "@DienThoai";
            name[4] = "@Email";
            name[5] = "@SoTienNo";

            values[0] = khachHangDTO.MaKhachHang;
            values[1] = khachHangDTO.HoTen;
            values[2] = khachHangDTO.DiaChi;
            values[3] = khachHangDTO.DienThoai;
            values[4] = khachHangDTO.Email;
            values[5] = khachHangDTO.SoTienNo;

            connect.ExcuteNonQuery("KhachHang_Update", name, values, param);
        }

        //Xóa một khách hàng theo MaKhachHang
        public void DeleteByMaKhachHang(KhachHangDTO khachHangDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaKhachHang";
            values[0] = khachHangDTO.MaKhachHang;

            connect.ExcuteNonQuery("KhachHang_DeleteByMaKhachHang", name, values, param);
        }
    }
}
