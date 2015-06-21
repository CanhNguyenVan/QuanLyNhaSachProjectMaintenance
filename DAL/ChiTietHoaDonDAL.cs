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
    public class ChiTietHoaDonDAL
    {
        private DataConnecter connect;

        public ChiTietHoaDonDAL()
        {
            connect = new DataConnecter();
        }

        public List<ChiTietHoaDonDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<ChiTietHoaDonDTO> list = new List<ChiTietHoaDonDTO>();

                dataTable = connect.GetData("ChiTietHoaDon_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
                    chiTietHoaDonDTO.MaHoaDon = dataTable.Rows[i].ItemArray[0].ToString();
                    chiTietHoaDonDTO.MaHoaDon = dataTable.Rows[i].ItemArray[1].ToString();
                    chiTietHoaDonDTO.MaSach = dataTable.Rows[i].ItemArray[2].ToString();
                    chiTietHoaDonDTO.SoLuongBan = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());

                    list.Add(chiTietHoaDonDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public void InsertChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            int param = 4;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietHoaDon";
            name[1] = "@MaHoaDon";
            name[2] = "@MaSach";
            name[3] = "@SoLuongBan";

            values[0] = chiTietHoaDonDTO.MaChiTietHoaDon;
            values[1] = chiTietHoaDonDTO.MaHoaDon;
            values[2] = chiTietHoaDonDTO.MaSach;
            values[3] = chiTietHoaDonDTO.SoLuongBan;

            connect.ExcuteNonQuery("ChiTietHoaDon_Insert", name, values, param);
        }

        public void UpdateChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            int param = 4;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietHoaDon";
            name[1] = "@MaHoaDon";
            name[2] = "@MaSach";
            name[3] = "@SoLuongBan";

            values[0] = chiTietHoaDonDTO.MaChiTietHoaDon;
            values[1] = chiTietHoaDonDTO.MaHoaDon;
            values[2] = chiTietHoaDonDTO.MaSach;
            values[3] = chiTietHoaDonDTO.SoLuongBan;

            connect.ExcuteNonQuery("ChiTietHoaDon_Update", name, values, param);
        }

        public void DeleteByMaChiTietsHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietHoaDon";
            values[0] = chiTietHoaDonDTO.MaChiTietHoaDon;

            connect.ExcuteNonQuery("ChiTietHoaDon_DeleteByMaChiTietHoaDon", name, values, param);
        }
    }
}
