using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAO
{
    public class UserDAO
    {
        static SqlConnection con;
        public static bool checkAccountDAO(string username, string password)
        {
            string query = "EXEC getAccount '" + username + "', '" + password + "'";
            con = DataProvider.openConnection();
            DataTable dt = DataProvider.DataRetrievalQuery(query, con);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                if (dt.Rows[0][1].Equals(username) && dt.Rows[0][2].Equals(password))
                return true;
                else return false;
            }
           

        }
        public static UserDTO getAccountDAO(string username)
        {
            
            string query="exec GetUserAccountByUsername @username ='"+username+"'";
            con = DataProvider.openConnection();
            DataTable dt = DataProvider.DataRetrievalQuery(query, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                UserDTO userDTO;
                if (dt.Rows[0]["image"]== DBNull.Value)
                {
                    // trong trường hợp ảnh khưởi tạo mặc định
                    int id = Convert.ToInt32(dt.Rows[0]["id"]);
                    string user = dt.Rows[0]["username"].ToString();
                    string pass = dt.Rows[0]["password"].ToString();
                    string fullName = dt.Rows[0]["fullName"].ToString();
                    string phoneNumber = dt.Rows[0]["phoneNumber"].ToString();
                    bool isAdmin = Convert.ToBoolean(dt.Rows[0]["isAdmin"]);
                    userDTO = new UserDTO(id, user, pass, fullName, phoneNumber, isAdmin, null);

                }
                else {
                    // trong trường hợp ảnh có dữ liệu trong data base
                    int id = Convert.ToInt32(dt.Rows[0]["id"]);
                    string user = dt.Rows[0]["username"].ToString();
                    string pass = dt.Rows[0]["password"].ToString();
                    string fullName = dt.Rows[0]["fullName"].ToString();
                    string phoneNumber = dt.Rows[0]["phoneNumber"].ToString();
                    bool isAdmin = Convert.ToBoolean(dt.Rows[0]["isAdmin"]);
                    byte[] image = (byte[])dt.Rows[0]["image"];
                    userDTO = new UserDTO(id, user, pass, fullName, phoneNumber, isAdmin, image);
                }
                return userDTO;
            }

        }


        public static int UpdateImageDAO(byte[] fileBinary, UserDTO loginAccount)
        {
            int rowsAffected=0;
            con = DataProvider.openConnection();
            if (loginAccount != null)
            {
                    string query = "UPDATE [UserAccount] SET [Image] = @ImageData WHERE [Username] = @Username";
                    SqlCommand command = new SqlCommand(query, con);
                    
                        // Add the parameters to the command
                    command.Parameters.AddWithValue("@ImageData", fileBinary);
                    command.Parameters.AddWithValue("@Username", loginAccount.Username);
                    // Execute the command
                    rowsAffected = command.ExecuteNonQuery();
             }
            return rowsAffected;
        }
        public static bool UpdateUserDAO(string username,string password,string fullname,string phonenumber) 
        { 
            con = DataProvider.openConnection();
            string query = "EXEC UpdateUserAccount @username = @userName, @password = @passWord, @fullname = @fullName, @phonenumber = @phoneNumber";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@userName", username);
            command.Parameters.AddWithValue("@passWord", password);
            command.Parameters.AddWithValue("@fullName", fullname);
            command.Parameters.AddWithValue("@phoneNumber", phonenumber);
            if (command.ExecuteNonQuery() == 1) return true;
            return false;
         
        }
        public static bool UpdateUserDAO(int userID, string username, string password, string fullname, string phonenumber, bool isAdmin, byte[] fileBinary)
        {
            // chỉnh lại các trường hợp trình tên tài khoản
            UserDTO user = getAccountDAO(username);
            if (user.Username != username)
            {
                return false;
            }
            else
            {
                con = DataProvider.openConnection();
                string query = "EXEC UpdateUserAccountWithAllProperties @ID = @userID, @Username = @userName, @Password = @passWord, @FullName = @fullName, @PhoneNumber = @phoneNumber, @IsAdmin = @isAdmin, @Image = @image";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@userName", username);
                command.Parameters.AddWithValue("@passWord", password);
                command.Parameters.AddWithValue("@fullName", fullname);
                command.Parameters.AddWithValue("@phoneNumber", phonenumber);
                command.Parameters.AddWithValue("@isAdmin", isAdmin);
                command.Parameters.Add("@image", SqlDbType.VarBinary).Value = fileBinary;
                if (command.ExecuteNonQuery() == 1) return true;
                return false;
            }
        }

        public static DataTable GetAllUserAccountDAO()
        {
            DataTable dataTable = new DataTable();
            con = DataProvider.openConnection();
            string query = "exec GetAllUserAccount";
            dataTable = DataProvider.DataRetrievalQuery(query, con);
            if(dataTable.Rows.Count == 0)
            {
                return null;
            }return dataTable;

        }
        public static bool InsertUserAccountDAO(string username, string password, string fullname, string phonenumber,int isadmin, byte[] fileBinary)
        {
            con = DataProvider.openConnection();
            string query = "EXEC InsertUser @username, @password, @fullname, @phonenumber, @isadmin, @image;";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
           
            command.Parameters.AddWithValue("@fullname", fullname);
            command.Parameters.AddWithValue("@phonenumber", phonenumber);
            command.Parameters.AddWithValue("@isadmin", isadmin);
            command.Parameters.Add("@image", SqlDbType.VarBinary).Value = fileBinary;
            if (command.ExecuteNonQuery() == 1) return true;
            return false;
        }
        public static bool DeleteUserDAO(int id)
        {
            con = DataProvider.openConnection();
            bool rowsAffected = false;
    
            string query = "exec DeleteAccount " + id;
            DataProvider.DatNonRetrievalQuery(query, con);
            // Execute the command
            return rowsAffected = DataProvider.DatNonRetrievalQuery(query, con);
        }
        public static DataTable GetAllUserWithIDAndFullnameDAO()
        {
            con = DataProvider.openConnection();
            DataTable table = new DataTable();
          
            table = DataProvider.DataRetrievalQuery("  select ID,FullName\r\n  from UserAccount", con); 
            // sử dụng data adapter rồi fill vào table
            return table;
        }


    }

}
