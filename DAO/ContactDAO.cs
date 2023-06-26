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
    
    public class ContactDAO
    {
       static SqlConnection con;

        public static List<ContactDTO> GetAllMessageByIdDAO(int senderId, int recipientId)
        {
            con = DataProvider.openConnection();
            SqlCommand command = new SqlCommand("GetContactsBySenderAndRecipient", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@senderId", senderId);
            command.Parameters.AddWithValue("@recipientId", recipientId);
            SqlDataReader reader = command.ExecuteReader();

            List<ContactDTO> contacts = new List<ContactDTO>();
            while (reader.Read())
            {
                ContactDTO contact = new ContactDTO
                {
                    ID = reader.GetInt32(0),
                    SenderID = reader.GetInt32(1),
                    RecipientID = reader.GetInt32(2),
                    Content = reader.GetString(3),
                    SentAt = reader.GetDateTime(4),
                    Status = reader.GetString(5),
                    SenderFullName = reader.GetString(6)
                };
                contacts.Add(contact);
            }

            return contacts;
        }


    }
}
