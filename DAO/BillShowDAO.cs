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
    public class BillShowDAO
    {
        static SqlConnection con;
        // phục vụ cho form bill
        public static List<BillShowDTO> GetAllBillDAO()
        {
            List<BillShowDTO> billShows = new List<BillShowDTO>();
            con = DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GetBillShow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BillShowDTO billShow = new BillShowDTO(
                        reader.GetInt32(reader.GetOrdinal("MaHoaDon")),
                        reader.GetDateTime(reader.GetOrdinal("NgayLap")),
                        reader.GetString(reader.GetOrdinal("TenKhachHang")),
                        reader.GetDateTime(reader.GetOrdinal("NgayThue")),
                        reader.GetDateTime(reader.GetOrdinal("NgayTra")),
                        reader.GetString(reader.GetOrdinal("TenXe")),
                        reader.GetInt32(reader.GetOrdinal("DonGia")),
                        reader.GetString(reader.GetOrdinal("NVLapPhieu")),
                        reader.GetInt32(reader.GetOrdinal("TongTien"))
                    );
                    billShows.Add(billShow);
                }
                reader.Close();
            }
            catch
            {
                return null;
            }
     
            return billShows;
        }

        public static DataTable GetHighestIncomFromVehicleDAO(DateTime StartDate, DateTime EndDate)
        {
            con = DataProvider.openConnection();
            DataTable XeList = new DataTable();
            SqlCommand cmd = new SqlCommand("GetHighestIncomFromVehicle", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(XeList);
            return XeList;
        }

        public static DataTable GetHighestIncomeByStaffDAO(DateTime StartDate, DateTime EndDate)
        {
            con = DataProvider.openConnection();
            DataTable StaffList = new DataTable();
            SqlCommand cmd = new SqlCommand("GetHighestIncomeByStaff", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(StaffList);
            return StaffList;
        }
        public static DataTable GetBillShowBetweenStartDateAndEndDateDAO(DateTime StartDate, DateTime EndDate)
        {
            con = DataProvider.openConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("GetBillShowBetweenStartDateAndEndDate", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@EndDate", EndDate);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            return dt;
        }

        
        public static DataTable GetBillShowByIdBillDAO(int id)
        {
            con = DataProvider.openConnection();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SelectBillByID", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            data.Fill(dt);
            return dt;
        }
        

    }
}
