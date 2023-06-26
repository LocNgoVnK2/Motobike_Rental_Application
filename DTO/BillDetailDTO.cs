using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDetailDTO
    {  int iD;
        int rentalID;
        int staffId;
        string fullName;
        DateTime billDate;
        int statusBill;
        DateTime rentalDate;
        DateTime? returnDate;
        int rentalFee;
        int? totalFee;


        public BillDetailDTO() { }



        public BillDetailDTO(int id, int rentalId, int staffId, string fullName, DateTime billDate, int statusBill,
            DateTime rentalDate, DateTime returnDate, int rentalFee, int totalFee)
        {
            ID = id;
            RentalID = rentalId;
            StaffId = staffId;
            FullName = fullName;
            BillDate = billDate;
            StatusBill = statusBill;
            RentalDate = rentalDate;
            ReturnDate = returnDate;
            RentalFee = rentalFee;
            TotalFee = totalFee;
        }

        public int ID { get => iD; set => iD = value; }
        public int RentalID { get => rentalID; set => rentalID = value; }
        public int StaffId { get => staffId; set => staffId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime BillDate { get => billDate; set => billDate = value; }
        public int StatusBill { get => statusBill; set => statusBill = value; }
        public DateTime RentalDate { get => rentalDate; set => rentalDate = value; }
       
        public int RentalFee { get => rentalFee; set => rentalFee = value; }
      
        public DateTime? ReturnDate { get => returnDate; set => returnDate = value; }
        public int? TotalFee { get => totalFee; set => totalFee = value; }
    }
}
