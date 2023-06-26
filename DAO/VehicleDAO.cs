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
    public class VehicleDAO
    {
        static SqlConnection con;
        public static DataTable GetAllVehicleDAO()
        {
            string query = "exec GetAllVehicle";
            con = DataProvider.openConnection();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = DataProvider.DataRetrievalQuery(query, con);
                if (dataTable.Rows.Count == 0)
                {
                    return null;
                }
                return dataTable;
            }
            catch
            {
                return null;
            }
    
        }

        public static bool UpdateVehicleDAO(int id, string brand, string model, string color, string licensePlate, string status, int categoryID, byte[] vehiclePicture, int rentalFee)
        {
            con = DataProvider.openConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("UpdateVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                cmd.Parameters.Add("@VehiclePicture", SqlDbType.VarBinary).Value = vehiclePicture;
                cmd.Parameters.AddWithValue("@RentalFee", rentalFee);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                // handle exception here
                return false;
            }
        }
        public static bool AddVehicleDAO( string brand, string model, string color, string licensePlate, string status, int categoryID, byte[] vehiclePicture, int rentalFee)
        {
            con = DataProvider.openConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("AddVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Model", model);
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@LicensePlate", licensePlate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                //cmd.Parameters.AddWithValue("@VehiclePicture", vehiclePicture);
                cmd.Parameters.Add("@VehiclePicture", SqlDbType.VarBinary).Value = vehiclePicture;
                cmd.Parameters.AddWithValue("@RentalFee", rentalFee);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                // handle exception here
                return false;
            }
        }
        public static bool DeleteVehicleDAO(int id )
        {
            con = DataProvider.openConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("DeleteVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                // handle exception here
                return false;
            }
        }
        public static List<VehicleDTO> loadVehicleList()
        {
            List<VehicleDTO> vehicles = new List<VehicleDTO>();
            DataTable dt = GetAllVehicleDAO();
            foreach(DataRow dr in dt.Rows)
            {
                VehicleDTO vehicle = new VehicleDTO(dr);
                vehicles.Add(vehicle);
            }
            return vehicles;
        }

        public static bool SetStatusVehicleDAO(int id, string status)
        {
            con = DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("SetStatusVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                return true;
            }catch { 
            return false;}
        }

    }
}
