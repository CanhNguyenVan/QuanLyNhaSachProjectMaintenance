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
    public class PhieuNhapDAL
    {
        private DataConnecter connect;

        //Constructor
        public PhieuNhapDAL()
        {
            connect = new DataConnecter();
        }

        //Hiển thị danh sách các phiếu nhập lên màn hình
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("PhieuNhap_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm mới một phiếu nhập
        public int InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 2;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            name[1] = "@NgayNhap";

            values[0] = phieuNhapDTO.MaPhieuNhap;
            values[1] = phieuNhapDTO.NgayNhap;

            return connect.ExcuteNonQuery("PhieuNhap_Insert", name, values, param);
        }

        //Sửa thông tin một phiếu nhập
        public int UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 2;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            name[1] = "@NgayNhap";

            values[0] = phieuNhapDTO.MaPhieuNhap;
            values[1] = phieuNhapDTO.NgayNhap;

            return connect.ExcuteNonQuery("PhieuNhap_Update", name, values, param);
        }

        //Xóa một phiếu nhập theo MaPhieuNhap
        public int DeleteByMaPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            values[0] = phieuNhapDTO.MaPhieuNhap;

            return connect.ExcuteNonQuery("PhieuNhap_DeleteByMaPhieuNhap", name, values, param);
        }
    }
}
