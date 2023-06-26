using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        int ID;
        int TotalFee;
        DateTime BillDate;
        int StatusbILL;
        int StaffID;
        int RentalID;


        public BillDTO() { }
        public BillDTO(int id, int totalFee, DateTime billDate, int status, int staffId, int rentalId)
        {
            this.ID = id;
            this.TotalFee = totalFee;
            this.BillDate = billDate;
            this.StatusbILL = status;
            this.StaffID = staffId;
            this.RentalID = rentalId;
       
        }
        public int ID1 { get => ID; set => ID = value; }
        public int TotalFee1 { get => TotalFee; set => TotalFee = value; }
        public DateTime BillDate1 { get => BillDate; set => BillDate = value; }
        public int StatusbILL1 { get => StatusbILL; set => StatusbILL = value; }
        public int StaffID1 { get => StaffID; set => StaffID = value; }
        public int RentalID1 { get => RentalID; set => RentalID = value; }

    }
}
