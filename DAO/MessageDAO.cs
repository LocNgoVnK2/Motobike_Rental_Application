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
    public class MessageDAO
    {
        static SqlConnection con;
        public static bool InsertMessageDAO(int senderId,int recipientId, string content,DateTime sentAt, string statusMess)
        {
            con = DataProvider.openConnection();
            try
            {
                SqlCommand command = new SqlCommand("InsertMessage", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@senderId", senderId);
                command.Parameters.AddWithValue("@recipientId", recipientId);
                command.Parameters.AddWithValue("@content", content);
                command.Parameters.AddWithValue("@sentAt", sentAt);
                command.Parameters.AddWithValue("@status", statusMess);
                command.ExecuteNonQuery();
                return true;
            } catch
            {
                return false;
            }
        }
        public static bool DeleteMessageDAO(int id)
        {
            con = DataProvider.openConnection();
            SqlCommand command = new SqlCommand("DeleteContact", con);
            command.CommandType=CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@contactId",id);
            return command.ExecuteNonQuery()>0;
        }
    }
}
