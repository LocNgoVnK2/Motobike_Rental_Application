using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MessageDTO
    {
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int RecipientID { get; set; }
        public string Content { get; set; }
        public DateTime SentAt { get; set; }
        public string Status { get; set; }
        public MessageDTO(int id, int senderId, int recipientId, string content, DateTime sentAt, string status)
        {
            ID = id;
            SenderID = senderId;
            RecipientID = recipientId;
            Content = content;
            SentAt = sentAt;
            Status = status;
        }
        public MessageDTO()
        {
            // Khởi tạo giá trị mặc định cho các thuộc tính
            ID = 0;
            SenderID = 0;
            RecipientID = 0;
            Content = string.Empty;
            SentAt = DateTime.MinValue;
            Status = string.Empty;
        }
    }
}

