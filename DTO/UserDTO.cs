using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {

        int id;
        string username;
        string password;
        string fullName;
        string phoneNumber;
        bool isAdmin;
        byte[] image;


        public UserDTO(int id, string username, string password, string fullName, string phoneNumber, bool isAdmin, byte[] image = null)
        {
            Id = id;
            Username = username;
            Password = password;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            IsAdmin = isAdmin;
            Image = image;
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public byte[] Image { get => image; set => image = value; }
    }
}
