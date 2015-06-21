using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class BaoCaoCongNoDAL
    {
        private DataConnecter connect;

        public BaoCaoCongNoDAL()
        {
            connect = new DataConnecter();
        }

        //Danh sách báo cáo công nợ
        public List<BaoCaoCongNoDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<BaoCaoCongNoDTO> list = new List<BaoCaoCongNoDTO>();


                dataTable = connect.GetData("BaoCaoCongNo_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    BaoCaoCongNoDTO baoCaoCongNoDTO = new BaoCaoCongNoDTO();
                    baoCaoCongNoDTO.MaBaoCaoCongNo = dataTable.Rows[i].ItemArray[0].ToString();
                    baoCaoCongNoDTO.Thang = int.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                    baoCaoCongNoDTO.MaKhachHang = dataTable.Rows[i].ItemArray[2].ToString();
                    baoCaoCongNoDTO.NoDau = float.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    baoCaoCongNoDTO.NoCuoi = float.Parse(dataTable.Rows[i].ItemArray[4].ToString());
                    baoCaoCongNoDTO.NoPhatSinh = float.Parse(dataTable.Rows[i].ItemArray[5].ToString());

                    list.Add(baoCaoCongNoDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public List<BaoCaoCongNoDTO> SelectByMonth()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<BaoCaoCongNoDTO> list = new List<BaoCaoCongNoDTO>();


                dataTable = connect.GetData("BaoCaoCongNo_SelectByMonth");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    BaoCaoCongNoDTO baoCaoCongNoDTO = new BaoCaoCongNoDTO();
                    baoCaoCongNoDTO.MaBaoCaoCongNo = dataTable.Rows[i].ItemArray[0].ToString();
                    baoCaoCongNoDTO.Thang = int.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                    baoCaoCongNoDTO.MaKhachHang = dataTable.Rows[i].ItemArray[2].ToString();
                    baoCaoCongNoDTO.NoDau = float.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    baoCaoCongNoDTO.NoCuoi = float.Parse(dataTable.Rows[i].ItemArray[4].ToString());
                    baoCaoCongNoDTO.NoPhatSinh = float.Parse(dataTable.Rows[i].ItemArray[5].ToString());

                    list.Add(baoCaoCongNoDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }
    }
}
