using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillDetailBUS
    {
        public static BillDetailDTO GetBillDetailByVehicleIdBUS(int vehicleId)
        {
            return BillDetailDAO.GetBillByVehicleId(vehicleId);
        }
    }
}
