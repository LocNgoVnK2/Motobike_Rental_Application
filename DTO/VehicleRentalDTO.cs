using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class VehicleRentalDTO
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int VehicleID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public VehicleRentalDTO()
        {
        }

        public VehicleRentalDTO(int id, int customerId, int vehicleId, DateTime rentalDate, DateTime? returnDate)
        {
            ID = id;
            CustomerID = customerId;
            VehicleID = vehicleId;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
        }
    }
}
