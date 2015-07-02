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
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("BaoCaoTon_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        //Danh Sách báo cáo tồn theo tháng
        public DataTable SelectByMonth()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("BaoCaoTon_SelectByMonth");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }
    }
}
