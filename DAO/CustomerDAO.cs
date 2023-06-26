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
    public class CustomerDAO
    {
        private static SqlConnection con;
        public static DataTable GetAllCustomerDAO()
        {
            DataTable dataTable = new DataTable();
            con = DataProvider.openConnection();
            string query = " exec GetAllCustomer";
            dataTable = DataProvider.DataRetrievalQuery(query, con);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return dataTable;
           
        }
    
        public static int DeletetCustomerDAO(int id)
        {
             int result = 0;
             con = DataProvider.openConnection();

             SqlCommand cmd = new SqlCommand("DeleteCustomer", con);
             cmd.CommandType = CommandType.StoredProcedure;

             cmd.Parameters.AddWithValue("@id", id);
                  

             result=cmd.ExecuteNonQuery();
             return result;
              
        }
        public static bool InsertCustomerDAO(string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            con = DataProvider.openConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@IdentityCardNumber", identityCardNumber);
                cmd.Parameters.AddWithValue("@DriverLicenseNumber", driverLicenseNumber);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                // handle exception here
                return false;
            }
        }
        public static bool UpdateCustomerDAO(int id,string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            con = DataProvider.openConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@IdentityCardNumber", identityCardNumber);
                cmd.Parameters.AddWithValue("@DriverLicenseNumber", driverLicenseNumber);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                // handle exception here
                return false;
            }
        }
        public static CustomerDTO GetUserByIdentityCardNumberDAO(string IdentityCardNumber)
        {
            con= DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GetCustomerByIdentityCardNumber", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identityCardNumber", IdentityCardNumber);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CustomerDTO customer = new CustomerDTO();
                    customer.Id = reader.GetInt32(reader.GetOrdinal("ID"));
                    customer.FullName = reader.GetString(reader.GetOrdinal("FullName"));
                    customer.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                    customer.Email = reader.GetString(reader.GetOrdinal("Email"));
                    customer.Address = reader.GetString(reader.GetOrdinal("Address"));
                    customer.IdentityCardNumber = reader.GetString(reader.GetOrdinal("IdentityCardNumber"));
                    customer.DriverLicenseNumber = reader.GetString(reader.GetOrdinal("DriverLicenseNumber"));

                    return customer;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }


    }
}
