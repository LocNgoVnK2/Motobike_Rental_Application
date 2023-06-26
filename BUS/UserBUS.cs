using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public static bool checkAccountBUS(string username, string password)
        {
            
            MD5 md5Hash = MD5.Create();
            string hashedPassword = GetMd5Hash(md5Hash, password);
            
            //if (UserDAO.checkAccountDAO(username, password))
                if (UserDAO.checkAccountDAO(username, hashedPassword))
                return true;
            return false;

        }
        public static UserDTO getAccountBUS(string username)
        {
            return UserDAO.getAccountDAO(username);
        }
        public static bool UpdateImageBUS(byte[] fileBinary, UserDTO loginAccount)
        {
            if (UserDAO.UpdateImageDAO(fileBinary, loginAccount) == 0) return false;
            return true;
        }
        public static bool UpdateUserBUS(string username, string password, string fullname, string phonenumber)
        {
            MD5 md5Hash = MD5.Create();
            string hashedPassword = GetMd5Hash(md5Hash, password);

            if (UserDAO.UpdateUserDAO(username, hashedPassword, fullname, phonenumber)) return true;
            return false;

        }
        public static DataTable GetAllUserAccountBUS()
        {
            return UserDAO.GetAllUserAccountDAO();

        }
        public static bool InsertUserAccountBUS(string username, string password, string fullname, string phonenumber, int isadmin, byte[] fileBinary)
        {
            MD5 md5Hash = MD5.Create();
            string hashedPassword = GetMd5Hash(md5Hash, password);
            if (UserDAO.InsertUserAccountDAO(username, hashedPassword, fullname, phonenumber, isadmin, fileBinary)) return true;
            return false;
        }
        public static bool DeleteUserBUS(int id)
        {
            if (UserDAO.DeleteUserDAO(id)) return true;
            return false;

        }
        public static bool UpdateUserBUS(int userID, string username, string password, string fullname, string phonenumber, bool isAdmin, byte[] fileBinary)
        {
            
            MD5 md5Hash = MD5.Create();
            string hashedPassword = GetMd5Hash(md5Hash, password);
            
            if (UserDAO.UpdateUserDAO(userID, username, hashedPassword, fullname, phonenumber, isAdmin, fileBinary))
                return true;
            return false;
 
        }
        public static DataTable GetAllUserWithIDAndFullnameBUS()
        {
            return UserDAO.GetAllUserWithIDAndFullnameDAO();
        }
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {// Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes// and create a
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}