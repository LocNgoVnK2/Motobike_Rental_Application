using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class CustomerBUS
    {
        public static DataTable GetAllCustomerBUS()
        {
           return CustomerDAO.GetAllCustomerDAO();

        }
        public static bool InsertCustomerBUS( string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            if (CustomerDAO.InsertCustomerDAO(fullName, phoneNumber, email, address, identityCardNumber, driverLicenseNumber)) return true;
            return false;
        }

        public static bool DeleteCustomerBUS(int id)
        {
            if(CustomerDAO.DeletetCustomerDAO(id)==1) return true;
            return false;
        }
        public static bool UpdateCustomerBUS(int id,string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            return CustomerDAO.UpdateCustomerDAO(id,fullName,phoneNumber,email,address,identityCardNumber,driverLicenseNumber); 
        }
        public static CustomerDTO GetUserByIdentityCardNumberDAO(string IdentityCardNumber)
        {
            return CustomerDAO.GetUserByIdentityCardNumberDAO(IdentityCardNumber);
        }

    }
}
