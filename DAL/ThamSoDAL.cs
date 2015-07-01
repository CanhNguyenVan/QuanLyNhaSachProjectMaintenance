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
            int param = 5;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = @"MaThamSo";
            names[1] = @"SoLuongNhapToiThieu";
            names[2] = @"SoLuongTonToiDaTruocKhiNhap";
            names[3] = @"SoLuongTonToiThieuTruocKhiBan";
            names[4] = @"TienNoToiDa";

            values[0] = thamSoDTO.MaThamSo;
            values[1] = thamSoDTO.SoLuongNhapToiThieu;
            values[2] = thamSoDTO.SoLuongTonToiDaTruocKhiNhap;
            values[3] = thamSoDTO.SoLuongTonToiThieuSauKhiBan;
            values[4] = thamSoDTO.TienNoToiDa;

            return connect.ExcuteNonQuery("ThamSo_Update", names, values, param);
        }
    }
}
