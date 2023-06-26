using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private int id;
        private string fullName;
        private string phoneNumber;
        private string email;
        private string address;
        private string identityCardNumber;
        private string driverLicenseNumber;

        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string IdentityCardNumber
        {
            get { return identityCardNumber; }
            set { identityCardNumber = value; }
        }

        public string DriverLicenseNumber
        {
            get { return driverLicenseNumber; }
            set { driverLicenseNumber = value; }
        }

        public CustomerDTO()
        {
            // Khởi tạo mặc định
        }

        public CustomerDTO(int id, string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            this.id = id;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.identityCardNumber = identityCardNumber;
            this.driverLicenseNumber = driverLicenseNumber;
        }
    }

}
