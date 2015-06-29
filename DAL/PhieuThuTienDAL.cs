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
                //List<PhieuThuTienDTO> list = new List<PhieuThuTienDTO>();

                dataTable = connect.GetData("PhieuThuTien_SelectAll");
                //int row = dataTable.Rows.Count;

                //for (int i = 0; i < row; i++)
                //{
                //    PhieuThuTienDTO phieuThuTienDTO = new PhieuThuTienDTO();
                //    phieuThuTienDTO.MaPhieuThuTien = dataTable.Rows[i].ItemArray[0].ToString();
                //    phieuThuTienDTO.SoTienThu = float.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                //    phieuThuTienDTO.MaKhachHang = dataTable.Rows[i].ItemArray[2].ToString();
                //    phieuThuTienDTO.NgayThu = DateTime.Parse(dataTable.Rows[i].ItemArray[3].ToString());

                //    list.Add(phieuThuTienDTO);
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
