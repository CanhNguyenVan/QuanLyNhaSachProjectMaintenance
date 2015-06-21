using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class BaoCaoTonDAL
    {
        private DataConnecter connect;

        public BaoCaoTonDAL()
        {
            connect = new DataConnecter();
        }

        //Danh sách báo cáo tồn
        public List<BaoCaoTonDTO> SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<BaoCaoTonDTO> list = new List<BaoCaoTonDTO>();


                dataTable = connect.GetData("BaoCaoTon_SelectAll");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    BaoCaoTonDTO baoCaoTonDTO = new BaoCaoTonDTO();
                    baoCaoTonDTO.MaBaoCaoTon = dataTable.Rows[i].ItemArray[0].ToString();
                    baoCaoTonDTO.Thang = int.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                    baoCaoTonDTO.TonDau = int.Parse(dataTable.Rows[i].ItemArray[2].ToString());
                    baoCaoTonDTO.TonCuoi = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    baoCaoTonDTO.TonPhatSinh = int.Parse(dataTable.Rows[i].ItemArray[4].ToString());

                    list.Add(baoCaoTonDTO);
                }

                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Danh Sách báo cáo tồn theo tháng
        public List<BaoCaoTonDTO> SelectByMonth()
        {
            try
            {
                DataTable dataTable = new DataTable();
                List<BaoCaoTonDTO> list = new List<BaoCaoTonDTO>();


                dataTable = connect.GetData("BaoCaoTon_SelectByMonth");
                int row = dataTable.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    BaoCaoTonDTO baoCaoTonDTO = new BaoCaoTonDTO();
                    baoCaoTonDTO.MaBaoCaoTon = dataTable.Rows[i].ItemArray[0].ToString();
                    baoCaoTonDTO.Thang = int.Parse(dataTable.Rows[i].ItemArray[1].ToString());
                    baoCaoTonDTO.TonDau = int.Parse(dataTable.Rows[i].ItemArray[2].ToString());
                    baoCaoTonDTO.TonCuoi = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
                    baoCaoTonDTO.TonPhatSinh = int.Parse(dataTable.Rows[i].ItemArray[4].ToString());

                    list.Add(baoCaoTonDTO);
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
