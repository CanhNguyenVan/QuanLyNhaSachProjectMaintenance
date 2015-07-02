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
        public DataTable SelectAll()
        {
            try
            {
                DataTable dataTable = new DataTable();

                dataTable = connect.GetData("BaoCaoCongNo_SelectAll");
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return null;
            }
        }

        public DataTable SelectByMonth()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = connect.GetData("BaoCaoCongNo_SelectByMonth");
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
