using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class VehicleBUS
    {
        public static DataTable GetAllVehicleBUS()
        {
            return VehicleDAO.GetAllVehicleDAO();
        }
        public static bool UpdateVehicleBUS(int id, string brand, string model, string color, string licensePlate, int categoryID, byte[] vehiclePicture, int rentalFee)
        {
            return VehicleDAO.UpdateVehicleDAO(id, brand, model, color, licensePlate, "free", categoryID, vehiclePicture, rentalFee);
        }
        public static bool AddVehicleBUS(string brand, string model, string color, string licensePlate, int categoryID, byte[] vehiclePicture, int rentalFee)
        {
            return VehicleDAO.AddVehicleDAO(brand, model, color, licensePlate, "free", categoryID, vehiclePicture, rentalFee);
        }

        public static bool DeleteVehicleBUS(int id)
        {
            return VehicleDAO.DeleteVehicleDAO(id);
        }
        public static List<VehicleDTO> loadVehicleListBUS()
        {

            return VehicleDAO.loadVehicleList();
        }
        public static bool SetStatusVehicleBUS(int id, string status)
        {
            return VehicleDAO.SetStatusVehicleDAO(id, status);
        }

    }
}
