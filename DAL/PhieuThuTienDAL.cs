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
    public class PhieuThuTienDAL
    {
        private DataConnecter connect;

        public PhieuThuTienDAL()
        {
            connect = new DataConnecter();
        }

        //Hiển thị danh sách phiếu thu tiền lên màn hình
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("PhieuThuTien_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm mới một phiếu thu tiền
        public int InsertPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            int param = 4;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuThuTien";
            name[1] = "@SoTienThu";
            name[2] = "@MaKhachHang";
            name[3] = "@NgayThu";

            values[0] = phieuThuTienDTO.MaPhieuThuTien;
            values[1] = phieuThuTienDTO.SoTienThu;
            values[2] = phieuThuTienDTO.MaKhachHang;
            values[3] = phieuThuTienDTO.NgayThu;

            return connect.ExcuteNonQuery("PhieuThuTien_Insert", name, values, param);
        }

        //Sửa một phiếu thu tiền
        public int UpdatePhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            int param = 4;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuThuTien";
            name[1] = "@SoTienThu";
            name[2] = "@MaKhachHang";
            name[3] = "@NgayThu";

            values[0] = phieuThuTienDTO.MaPhieuThuTien;
            values[1] = phieuThuTienDTO.SoTienThu;
            values[2] = phieuThuTienDTO.MaKhachHang;
            values[3] = phieuThuTienDTO.NgayThu;

            return connect.ExcuteNonQuery("PhieuThuTien_Update", name, values, param);
        }

        //Xóa một phiếu thu tiền theo mã phiếu thu tiền
        public int DeleteByMaPhieuThuTien(PhieuThuTienDTO phieuThuTienDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuThuTien";
            values[0] = phieuThuTienDTO.MaPhieuThuTien;

            return connect.ExcuteNonQuery("PhieuThuTien_DeleteByMaPhieuThuTien", name, values, param);
        }
    }
}
