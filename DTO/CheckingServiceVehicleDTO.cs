using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CheckingServiceVehicleDTO
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool Status { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleStatus { get; set; }

        public int RentalFee { get; set; }
    
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IdentityCardNumber { get; set; }
        public string DriverLicenseNumber { get; set; }

        public CheckingServiceVehicleDTO(int id, int customerID, int vehicleID, DateTime rentalDate, DateTime? returnDate, string brand, string model, string licensePlate, string vehicleStatus, int rentalFee, string fullName, string phoneNumber, string email, string address, string identityCardNumber, string driverLicenseNumber)
        {
            ID = id;
            CustomerID = customerID;
            VehicleID = vehicleID;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            VehicleStatus = vehicleStatus;
            RentalFee = rentalFee;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            IdentityCardNumber = identityCardNumber;
            DriverLicenseNumber = driverLicenseNumber;
        }
    }
}
