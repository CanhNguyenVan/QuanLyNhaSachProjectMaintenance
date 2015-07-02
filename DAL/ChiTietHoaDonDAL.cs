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

        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("ChiTietHoaDon_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
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

            return connect.ExcuteNonQuery("ChiTietHoaDon_Insert", name, values, param);
        }

        public int UpdateChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
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

            return connect.ExcuteNonQuery("ChiTietHoaDon_Update", name, values, param);
        }

        public int DeleteByMaChiTietsHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietHoaDon";
            values[0] = chiTietHoaDonDTO.MaChiTietHoaDon;

            return connect.ExcuteNonQuery("ChiTietHoaDon_DeleteByMaChiTietHoaDon", name, values, param);
        }
    }
}
