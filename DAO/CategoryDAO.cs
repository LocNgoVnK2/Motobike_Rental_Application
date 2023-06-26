using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoryDAO
    {
        static SqlConnection con;
        static DataTable dt;
        public static DataTable GetCategoryDAO()
        {
            con = DataProvider.openConnection();
            string query = "exec GetCategory";
            dt = DataProvider.DataRetrievalQuery(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
