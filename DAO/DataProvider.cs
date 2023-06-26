using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataProvider
    {
        public static SqlConnection openConnection()
        {
            string s = @"Data Source=(local);Initial Catalog=MotoBikeRental;Integrated Security=True";
            SqlConnection connect = new SqlConnection(s);
            connect.Open();
            return connect;
        }
        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable DataRetrievalQuery(string query, SqlConnection connect)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        public static bool DatNonRetrievalQuery(string query, SqlConnection connect)
        {
            try
            {
                SqlCommand cm = new SqlCommand(query, connect);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
