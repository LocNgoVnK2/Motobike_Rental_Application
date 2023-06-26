using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VehicleRentalDAO
    {
        static SqlConnection con;
        public static bool InsertVehicleRentalDAO(int CustomerId, int VehicleId,DateTime RentalDate)
        {
         
            con = DataProvider.openConnection();
            try
            {
                string query = "InsertVehicleRental";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", CustomerId);
                cmd.Parameters.AddWithValue("@VehicleID", VehicleId);
                cmd.Parameters.AddWithValue("@RentalDate", RentalDate);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public static VehicleRentalDTO GetCurrentVehicleRentalDAO()
        {
            con =DataProvider.openConnection();
        
                string query = "GetVehicleRental";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    VehicleRentalDTO vehicleRental = new VehicleRentalDTO();
                    vehicleRental.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                    vehicleRental.CustomerID = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                    vehicleRental.VehicleID = reader.GetInt32(reader.GetOrdinal("VehicleID"));
                    vehicleRental.RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ReturnDate")))
                    {
                        vehicleRental.ReturnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate"));
                    }
                    else
                    {
                        vehicleRental.ReturnDate = null;
                    }
                    return vehicleRental;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public static bool UpdateRentalReturnDateDAO(int id, DateTime returnDate)
        {
            con = DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateRentalReturnDate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);

                int rowsAffected = cmd.ExecuteNonQuery();
                return (rowsAffected > 0); // lớn hơn 0 nếu nó thành công true
            }
            catch 
            {
                return false;
            }
  
        }

    }
}
