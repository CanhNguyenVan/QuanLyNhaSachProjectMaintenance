using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class MySqlConnection
    {
        static SqlConnection sqlConnect = new SqlConnection();
        static SqlDataAdapter adap = new SqlDataAdapter();
        static SqlCommand cmd = new SqlCommand();
        static SqlCommandBuilder cb = new SqlCommandBuilder();

        public static void OpenConnection()
        {
            try
            {
                sqlConnect = new SqlConnection(@"Data Source=PHAMHONGSON-PC;Initial Catalog=QuanLyNhaSachMaintenance;Integrated Security=True");

                

                sqlConnect.Open();
                //MessageBox.Show("thang cong");
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!");
            }
        }

        public void CloseConnecttion()
        {
            sqlConnect.Close();
        }

        //public static void setData(string TENBANG, DataSet dt)
        //{
        //    string sql = string.Format("select * from {0}", TENBANG);
        //    cmd = new SqlCommand(sql, sqlConnect);
        //    adap = new SqlDataAdapter(cmd);
        //    adap.Fill(dt, TENBANG);
        //    cb = new SqlCommandBuilder(adap);
        //}
        
        ////thực thi dòng lệnh nào đó trong C# vào sql như thêm dữ liệu
        ////sử dụng cho các button là chính

        //public static void Execute(string command)
        //{
        //    SqlCommand sqlCommand = new SqlCommand(command, sqlConnect);
        //    sqlCommand.CommandText = command;
        //    sqlCommand.ExecuteNonQuery();
        //}


        ////lấy dữ liệu từ bảng TenBang
        ////sử dụng cho việc hiển thị dữ liệu vào dataGidView
        //public static DataTable LoadData(string TenBang)
        //{
        //    SqlCommand sqlCommand = new SqlCommand("select * from " + TenBang, sqlConnect);
        //    sqlCommand.ExecuteNonQuery();
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataSet dataSet = new DataSet();
        //    dataAdapter.Fill(dataSet, TenBang);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
        //    return dataSet.Tables[0];
        //}

        ////tìm kiếm và lọc dữ liệu trong bảng TenBang với từ khóa là key, điều kiện lọc là Condition trong ColumnName 
        ////sử dụng trong DataGridView

        //public static DataTable Filter_data(string TenBang, string key, string ColumnName, string Condition)
        //{
        //    string sql = ("select * from ") + TenBang + " WHERE " + key + " " + ColumnName + " " + Condition;
        //    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
        //    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
        //    SqlCommandBuilder cmb = new SqlCommandBuilder(dAdapter);
        //    DataSet dSet = new DataSet();
        //    dAdapter.Fill(dSet, TenBang);
        //    return dSet.Tables[0];
        //}

        //public static DataTable docommand(string TenBang, string key)
        //{
        //    string sql = ("select * from ") + TenBang + " WHERE " + key ;
        //    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
        //    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
        //    SqlCommandBuilder cmb = new SqlCommandBuilder(dAdapter);
        //    DataSet dSet = new DataSet();
        //    dAdapter.Fill(dSet, TenBang);
        //    return dSet.Tables[0];
        //}

    }
}
