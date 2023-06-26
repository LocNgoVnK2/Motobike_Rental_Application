using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BillShowBUS
    {
        public static List<BillShowDTO> GetAllBillBUS()
        {
            return BillShowDAO.GetAllBillDAO();
        }
        public static DataTable GetHighestIncomFromVehicleBUS(DateTime StartDate, DateTime EndDate)
        {
            return BillShowDAO.GetHighestIncomFromVehicleDAO(StartDate, EndDate);
        }
        public static DataTable GetHighestIncomeByStaffBUS(DateTime StartDate, DateTime EndDate)
        {
            return BillShowDAO.GetHighestIncomeByStaffDAO(StartDate, EndDate);
        }
        public static DataTable GetBillShowBetweenStartDateAndEndDateBUS(DateTime StartDate, DateTime EndDate)
        { 
            return BillShowDAO.GetBillShowBetweenStartDateAndEndDateDAO(StartDate, EndDate);
        }
        public static DataTable GetBillShowByIdBillBUS(int id)
        { 
            return BillShowDAO.GetBillShowByIdBillDAO(id);
        }
        }
}
