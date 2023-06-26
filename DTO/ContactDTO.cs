using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ContactDTO
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public string Status { get; set; }
        public string SenderFullName { get; set; }

        public ContactDTO() { }

        public ContactDTO(int id, int senderID, int recipientID, string content, DateTime sentAt, string status, string senderFullName)
        {
            ID = id;
            SenderID = senderID;
            RecipientID = recipientID;
            Content = content;
            SentAt = sentAt;
            Status = status;
            SenderFullName = senderFullName;
        }
    }


}
