using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VehicleDTO
    {
        private int id;
        private string brand;
        private string model;
        private string color;
        private string licensePlate;
        private string status;
        private int categoryId;
        private string categoryName;
        private byte[] vehiclePicture;
        private int rentalFee;

        public VehicleDTO()
        {
        }

        public VehicleDTO(int id, string brand, string model, string color, string licensePlate,
            string status, int categoryId, int rentalFee, string categoryName, byte[] vehiclePicture = null)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            LicensePlate = licensePlate;
            Status = status;
            CategoryId = categoryId;
            VehiclePicture = vehiclePicture;
            RentalFee = rentalFee;
            CategoryName = categoryName;
        }
        public VehicleDTO(DataRow row)
        {
                    Id = Convert.ToInt32(row["ID"]);
                    Brand = row["Brand"].ToString();
                    Model = row["Model"].ToString();
                    Color = row["Color"].ToString();
                    LicensePlate = row["LicensePlate"].ToString();
                    Status = row["Status"].ToString();
                    CategoryId = Convert.ToInt32(row["CategoryID"]);
                    CategoryName = Convert.ToString(row["CategoryName"]);
                    RentalFee = Convert.ToInt32(row["RentalFee"]);
                    VehiclePicture = row["VehiclePicture"] as byte[];
        }



        public int Id { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public string Status { get => status; set => status = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public byte[] VehiclePicture { get => vehiclePicture; set => vehiclePicture = value; }
        public int RentalFee { get => rentalFee; set => rentalFee = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
    }
}
