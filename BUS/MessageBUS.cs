using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MessageBUS
    {
        public static bool InsertMessageBUS(int senderId, int recipientId, string content, DateTime sentAt)
        { 
            return MessageDAO.InsertMessageDAO(senderId, recipientId, content, sentAt,"Sent"); 
        }
        public static bool DeleteMessageDAO(int id)
        { 
            return MessageDAO.DeleteMessageDAO(id);
        }
        }
}
