using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BillBUS
    {
        public static bool InsertBillBUS(DateTime BillDate, int StaffId, int RentalID)
        {
            return BillDAO.InsertBillDAO(BillDate,0,StaffId,RentalID);
        }
        public static bool UpdateBillTotalFeeAndStatusBillBUS(int id, int totalFee)
        { 
            return BillDAO.UpdateBillTotalFeeAndStatusBillDAO(id,totalFee);
        }
        }
}
