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
        public List<HoaDonDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<HoaDonDTO> list = new List<HoaDonDTO>();

                dataTable = connect.GetData("HoaDon_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    HoaDonDTO hoaDonDTO = new HoaDonDTO();
                    hoaDonDTO.MaHoaDon = dataTable.Rows[i].ItemArray[0].ToString();
                    hoaDonDTO.MaKhachHang = dataTable.Rows[i].ItemArray[1].ToString();
                    hoaDonDTO.NgayLap = DateTime.Parse(dataTable.Rows[i].ItemArray[2].ToString());

                    list.Add(hoaDonDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //thêm mới một hóa đơn
        public void InsertHoaDon(HoaDonDTO hoaDonDTO)
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

            connect.ExcuteNonQuery("HoaDon_Insert", name, values, param);
        }

        //Sửa thông tin một hóa đơn
        public void UpdateHoaDon(HoaDonDTO hoaDonDTO)
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

            connect.ExcuteNonQuery("HoaDon_Update", name, values, param);
        }

        //Xóa một hóa đơn theo MaHoaDon
        public void DeleteByMaHoaDon(HoaDonDTO hoaDonDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaHoaDon";
            values[0] = hoaDonDTO.MaHoaDon;

            connect.ExcuteNonQuery("HoaDon_DeleteByMaHoaDon", name, values, param);
        }
    }
}
