using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class VehicleRentalBUS
    {
        public static bool InsertVehicleRentalBUS(int CustomerId, int VehicleId, DateTime RentalDate)
        {
            return VehicleRentalDAO.InsertVehicleRentalDAO(CustomerId, VehicleId, RentalDate);
        }
        public static VehicleRentalDTO GetCurrentVehicleRentalBUS()
        {
            return VehicleRentalDAO.GetCurrentVehicleRentalDAO();
        }
        public static bool UpdateRentalReturnDateBUS(int id, DateTime returnDate)
        { 
            return VehicleRentalDAO.UpdateRentalReturnDateDAO(id, returnDate);
        }
    }
}
