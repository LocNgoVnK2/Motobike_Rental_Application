using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;

        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\MotoBikeRental(" + DateTime.Now.Day.ToString() + "_" +
                DateTime.Now.Month.ToString() + "_" +
                DateTime.Now.Year.ToString() + "_" +
                DateTime.Now.Hour.ToString() + "_" +
                DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE MotoBikeRental TO DISK = N'" + sDuongDan +
                sTen + "'";
            SqlConnection con = DataProvider.openConnection();
            bool kq = DataProvider.DatNonRetrievalQuery(sql, con);
            con.Close();
            return kq;
        }

        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            string sql = "USE master; ALTER DATABASE MotoBikeRental SET SINGLE_USER WITH ROLLBACK IMMEDIATE; " +
                "RESTORE DATABASE MotoBikeRental FROM DISK = N'" + sDuongDan + "' WITH REPLACE; " +
                "ALTER DATABASE MotoBikeRental SET MULTI_USER;";
            SqlConnection con = DataProvider.openConnection();
            bool kq = DataProvider.DatNonRetrievalQuery(sql, con);
            con.Close();
            return kq;
        }

    }
}
