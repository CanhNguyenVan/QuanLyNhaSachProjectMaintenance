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
        public List<PhieuNhapDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<PhieuNhapDTO> list = new List<PhieuNhapDTO>();

                dataTable = connect.GetData("PhieuNhap_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                    phieuNhapDTO.MaPhieuNhap = dataTable.Rows[i].ItemArray[0].ToString();
                    phieuNhapDTO.NgayNhap = DateTime.Parse(dataTable.Rows[i].ItemArray[1].ToString());

                    list.Add(phieuNhapDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Thêm mới một phiếu nhập
        public void InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 2;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            name[1] = "@NgayNhap";

            values[0] = phieuNhapDTO.MaPhieuNhap;
            values[1] = phieuNhapDTO.NgayNhap;

            connect.ExcuteNonQuery("PhieuNhap_Insert", name, values, param);
        }

        //Sửa thông tin một phiếu nhập
        public void UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 2;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            name[1] = "@NgayNhap";

            values[0] = phieuNhapDTO.MaPhieuNhap;
            values[1] = phieuNhapDTO.NgayNhap;

            connect.ExcuteNonQuery("PhieuNhap_Update", name, values, param);
        }

        //Xóa một phiếu nhập theo MaPhieuNhap
        public void DeleteByMaPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            int param = 1;
            string[] name = new string[param];
            object[] values = new object[param];

            name[0] = "@MaPhieuNhap";
            values[0] = phieuNhapDTO.MaPhieuNhap;

            connect.ExcuteNonQuery("PhieuNhap_DeleteByMaPhieuNhap", name, values, param);
        }
    }
}
