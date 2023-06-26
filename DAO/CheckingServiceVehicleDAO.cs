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
    public class CheckingServiceVehicleDAO
    {
        static SqlConnection con;
        public static CheckingServiceVehicleDTO CheckingServiceDAO(int id) {

            con = DataProvider.openConnection();
            CheckingServiceVehicleDTO result = null;

            SqlCommand cmd = new SqlCommand("GetCheckingServiceVehicleByID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {   int rentalID = Convert.ToInt32(reader["ID"]);
                    int customerID = Convert.ToInt32(reader["CustomerID"]);
                    int vehicleID = Convert.ToInt32(reader["VehicleID"]);
                    DateTime rentalDate = Convert.ToDateTime(reader["RentalDate"]);
                    DateTime? returnDate = reader["ReturnDate"] == DBNull.Value ? null : (DateTime?)Convert.ToDateTime(reader["ReturnDate"]);
                    string brand = Convert.ToString(reader["Brand"]);
                    string model = Convert.ToString(reader["Model"]);
                    string licensePlate = Convert.ToString(reader["LicensePlate"]);
                    string vehicleStatus = Convert.ToString(reader["VehicleStatus"]);
                    int rentalFee = Convert.ToInt32(reader["RentalFee"]);
                    string fullName = Convert.ToString(reader["FullName"]);
                    string phoneNumber = Convert.ToString(reader["PhoneNumber"]);
                    string email = Convert.ToString(reader["Email"]);
                    string address = Convert.ToString(reader["Address"]);
                    string identityCardNumber = Convert.ToString(reader["IdentityCardNumber"]);
                    string driverLicenseNumber = Convert.ToString(reader["DriverLicenseNumber"]);
                 

                    result = new CheckingServiceVehicleDTO(rentalID,customerID,vehicleID,rentalDate,returnDate,brand,model,licensePlate,vehicleStatus,rentalFee,fullName,phoneNumber,email,address,identityCardNumber,driverLicenseNumber);
                }
            }


            return result;
        }
    }
}
