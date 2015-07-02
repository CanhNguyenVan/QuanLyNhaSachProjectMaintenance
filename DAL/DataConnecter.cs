using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DataConnecter
    {
        // Tạo đối tượng kết nối đến CSDL
        SqlConnection sqlConnect = new SqlConnection();
        // Chuỗi kết nối
        string strConnect;

        // Contructor
        public DataConnecter()
        {
            strConnect = ConfigurationManager.ConnectionStrings["QuanLyNhaSachMaintenanceConnectionString"].ConnectionString;
            sqlConnect.ConnectionString = strConnect;
            if (sqlConnect.State == ConnectionState.Closed)
                try
                {
                    sqlConnect.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Constants.LoadDataError);
                }
        }

        public int Backup(string fileName)
        {
            try
            {
                string query = "Backup Database QuanLyNhaSachMaintenance To Disk='" + fileName + ".bak' With Format";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnect);
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.LoadDataError);
                return 0;
            }   
        }

        public int Restore(string fileName)
        {
            try{
                string sql = "Alter Database QuanLyNhaSachMaintenance Set Offline With Rollback Immediate Use master Restore Database QuanLyNhaSachMaintenance From Disk ='" + fileName + "' With Replace Alter Database QuanLyNhaSachMaintenance Set Online";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                sqlCommand.CommandType = CommandType.Text;
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constants.LoadDataError);
                return 0;
            }   
        }

        public DataTable GetData(string sql)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return dataTable;
            }
        }

        public DataTable GetData(string sql, string[] name, object[] value, int param)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < param; i++)
                {
                    sqlCommand.Parameters.AddWithValue(name[i],value[i]);
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return dataTable;
            }
        }

        public int ExcuteNonQuery(string sql)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,Constants.LoadDataError);
                return 0;
            }
        }

        public int ExcuteNonQuery(string sql, string[] name, object[] value, int param)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < param; i++)
                {
                    sqlCommand.Parameters.AddWithValue(name[i], value[i]);
                }
                return sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Constants.LoadDataError);
                return 0;
            }
        }
    }
}
