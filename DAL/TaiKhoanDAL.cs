using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class TaiKhoanDAL
    {
        DataConnecter connect;
        public TaiKhoanDAL()
        {
            connect = new DataConnecter();
        }

        public DataTable SelectAll()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = connect.GetData("TaiKhoan_SelectAll");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
            }
            return dataTable;
        }
        
        public DataTable SelectLastMaTK()
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = connect.GetData("TaiKhoan_SelectLastMaTK");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
            }
            return dataTable;
        }

        public int InsertTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";
            names[1] = "@TenTK";
            names[2] = "@MatKhau";
            names[3] = "@LoaiTK";

            values[0] = taiKhoanDTO.MaTaiKhoan;
            values[1] = taiKhoanDTO.TenTaiKhoan;
            values[2] = taiKhoanDTO.MatKhau;
            values[3] = taiKhoanDTO.LoaiTaiKhoan;

            return connect.ExcuteNonQuery("TaiKhoan_Insert", names, values, param);
        }

        public int UpdateTaiKhoan(TaiKhoanDTO taiKhoanDTO)
        {
            int param = 4;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";
            names[1] = "@TenTK";
            names[2] = "@MatKhau";
            names[3] = "@LoaiTK";

            values[0] = taiKhoanDTO.MaTaiKhoan;
            values[1] = taiKhoanDTO.TenTaiKhoan;
            values[2] = taiKhoanDTO.MatKhau;
            values[3] = taiKhoanDTO.LoaiTaiKhoan;

            return connect.ExcuteNonQuery("TaiKhoan_Update", names, values, param);
        }

        public int DeleteTaiKhoan(string maTaiKhoan)
        {
            int param = 1;
            string[] names = new string[param];
            object[] values = new object[param];

            names[0] = "@MaTK";

            values[0] = maTaiKhoan;

            return connect.ExcuteNonQuery("TaiKhoan_Delete", names, values, param);
        }
    }
}
