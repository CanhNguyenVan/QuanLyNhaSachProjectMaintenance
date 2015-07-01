using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class ThamSoDAL
    {
        DataConnecter connect;
        public ThamSoDAL()
        {
            connect = new DataConnecter();
        }
        public DataTable SelectAll()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = connect.GetData("ThamSo_SelectAll");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
            }
            return dataTable;
        }

        public int UpdateThamSo(ThamSoDTO thamSoDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = @"SoLuongNhapToiThieu";
            names[1] = @"SoLuongTonToiDaTruocKhiNhap";
            names[2] = @"SoLuongTonToiThieuTruocKhiBan";
            names[3] = @"TienNoToiDa";

            values[0] = thamSoDTO.SoLuongNhapToiThieu;
            values[1] = thamSoDTO.SoLuongTonToiDaTruocKhiNhap;
            values[2] = thamSoDTO.SoLuongTonToiThieuSauKhiBan;
            values[3] = thamSoDTO.TienNoToiDa;

            return connect.ExcuteNonQuery("ThamSo_Update", names, values, param);
        }
    }
}
