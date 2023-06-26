using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDAO
    {
        static SqlConnection con;
        public static bool InsertBillDAO(DateTime BillDate,int StatusBill,int StaffId,int RentalID)
        {
            con = DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("InsertBill", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BillDate", BillDate);
                cmd.Parameters.AddWithValue("@StatusBill ", StatusBill);
                cmd.Parameters.AddWithValue("@StaffId ", StaffId);
                cmd.Parameters.AddWithValue("@RentalID", RentalID);

                cmd.ExecuteNonQuery();
                return true;
            }catch{ 
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public static bool UpdateBillTotalFeeAndStatusBillDAO(int id, int totalFee)
        {
            con = DataProvider.openConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateBillTotalFeeAndStatusBill", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@totalFee", totalFee);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }

        }
       
    }
}
