using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ThuVien.DAO
{
    public class DataProvider
    {
       private  string connectionSTR = @"Data Source=D2T-PC\SQLEXPRESS;Initial Catalog=dbQLThuViennnn;Integrated Security=True";
        public DataTable Executequery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
                //// sử dụng using khi kết thúc khối lệnh , dữ liệu tự đc giải phóng
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
