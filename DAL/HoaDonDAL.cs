using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class HoaDonDAL
    {
        private DataConnecter connect;

        public HoaDonDAL()
        {
            connect = new DataConnecter();
        }

        //Hiển thị danh sách hóa đơn lên màn hình
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("HoaDon_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //thêm mới một hóa đơn
        public int InsertHoaDon(HoaDonDTO hoaDonDTO)
        {
            int param = 3;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaHoaDon";
            name[1] = "@MaKhachHang";
            name[2] = "@NgayLap";

            values[0] = hoaDonDTO.MaHoaDon;
            values[1] = hoaDonDTO.MaKhachHang;
            values[2] = hoaDonDTO.NgayLap;

            return connect.ExcuteNonQuery("HoaDon_Insert", name, values, param);
        }

        //Sửa thông tin một hóa đơn
        public int UpdateHoaDon(HoaDonDTO hoaDonDTO)
        {
            int param = 3;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaHoaDon";
            name[1] = "@MaKhachHang";
            name[2] = "@NgayLap";

            values[0] = hoaDonDTO.MaHoaDon;
            values[1] = hoaDonDTO.MaKhachHang;
            values[2] = hoaDonDTO.NgayLap;

            return connect.ExcuteNonQuery("HoaDon_Update", name, values, param);
        }

        //Xóa một hóa đơn theo MaHoaDon
        public int DeleteByMaHoaDon(HoaDonDTO hoaDonDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaHoaDon";
            values[0] = hoaDonDTO.MaHoaDon;

            return connect.ExcuteNonQuery("HoaDon_DeleteByMaHoaDon", name, values, param);
        }
    }
}
