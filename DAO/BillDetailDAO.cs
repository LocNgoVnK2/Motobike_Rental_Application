using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillDetailDAO
    {
        static SqlConnection con;
        // dể load theo mấy xe có được lập bill
        public static BillDetailDTO GetBillByVehicleId(int vehicleId)
        {
            con = DataProvider.openConnection();
        
                SqlCommand cmd = new SqlCommand("GetBillByVehicleId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VehicleId", vehicleId);
                SqlDataReader reader=  cmd.ExecuteReader();
                if (reader.Read())
                {
                    BillDetailDTO billDetailDTO = new BillDetailDTO();
                    billDetailDTO.ID = Convert.ToInt32( reader["ID"]);
                    billDetailDTO.RentalID = Convert.ToInt32(reader["RentalID"]);
                    billDetailDTO.StaffId = Convert.ToInt32(reader["staffId"]);
                    billDetailDTO.FullName = reader["FullName"].ToString();
                    billDetailDTO.BillDate = Convert.ToDateTime(reader["BillDate"]);
                    billDetailDTO.StatusBill = Convert.ToInt32(reader["StatusBill"]);
                    billDetailDTO.RentalDate = Convert.ToDateTime(reader["RentalDate"]);
                    if (!reader.IsDBNull(reader.GetOrdinal("ReturnDate")))
                    {
                        billDetailDTO.ReturnDate = Convert.ToDateTime(reader["ReturnDate"]);
                    }
                    else
                    {
                        billDetailDTO.ReturnDate = null;
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("TotalFee")))
                    {
                        billDetailDTO.TotalFee = Convert.ToInt32(reader["TotalFee"]);
                    }
                    else
                    {
                        billDetailDTO.TotalFee = null;
                    }
                    billDetailDTO.RentalFee = Convert.ToInt32(reader["RentalFee"]);
                    return billDetailDTO;
                }   return null;
        }
    }
}
