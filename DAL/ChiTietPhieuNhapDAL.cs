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
    public class ChiTietPhieuNhapDAL
    {
        private DataConnecter connect;

        public ChiTietPhieuNhapDAL()
        {
            connect = new DataConnecter();
        }

        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                //List<ChiTietPhieuNhapDTO> list = new List<ChiTietPhieuNhapDTO>();

                dataTable = connect.GetData("ChiTietPhieuNhap_SelectAll");
                //int row = dataTable.Rows.Count;

                //for (int i = 0; i < row; i++)
                //{
                //    ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                //    chiTietPhieuNhapDTO.MaChiTietPhieuNhap = dataTable.Rows[i].ItemArray[0].ToString();
                //    chiTietPhieuNhapDTO.MaPhieuNhap = dataTable.Rows[i].ItemArray[1].ToString();
                //    chiTietPhieuNhapDTO.MaSach = dataTable.Rows[i].ItemArray[2].ToString();
                //    chiTietPhieuNhapDTO.SoLuongNhap = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                //    chiTietPhieuNhapDTO.DonGiaNhap = float.Parse(dataTable.Rows[i].ItemArray[4].ToString());

                //    list.Add(chiTietPhieuNhapDTO);
                //}

                //return list;
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public int InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            int param = 5;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietPhieuNhap";
            name[1] = "@MaPhieuNhap";
            name[2] = "@MaSach";
            name[3] = "@SoLuongNhap";
            name[4] = "@DonGiaNhap";

            values[0] = chiTietPhieuNhapDTO.MaChiTietPhieuNhap;
            values[1] = chiTietPhieuNhapDTO.MaPhieuNhap; ;
            values[2] = chiTietPhieuNhapDTO.MaSach;
            values[3] = chiTietPhieuNhapDTO.SoLuongNhap;
            values[4] = chiTietPhieuNhapDTO.DonGiaNhap;

            return connect.ExcuteNonQuery("ChiTietPhieuNhap_Insert", name, values, param);
        }

        public int UpdateChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            int param = 5;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietPhieuNhap";
            name[1] = "@MaPhieuNhap";
            name[2] = "@MaSach";
            name[3] = "@SoLuongNhap";
            name[4] = "@DonGiaNhap";

            values[0] = chiTietPhieuNhapDTO.MaChiTietPhieuNhap;
            values[1] = chiTietPhieuNhapDTO.MaPhieuNhap; ;
            values[2] = chiTietPhieuNhapDTO.MaSach;
            values[3] = chiTietPhieuNhapDTO.SoLuongNhap;
            values[4] = chiTietPhieuNhapDTO.DonGiaNhap;

            return connect.ExcuteNonQuery("ChiTietPhieuNhap_Update", name, values, param);
        }

        public int DeleteByMaChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaChiTietPhieuNhap";
            values[0] = chiTietPhieuNhapDTO.MaChiTietPhieuNhap;

            return connect.ExcuteNonQuery("ChiTietPhieNhap_DeleteByMaChiTietPhieuNhap", name, values, param);
        }
    }
}
