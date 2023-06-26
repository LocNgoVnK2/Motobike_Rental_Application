using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXeMay.FormService
{
    public partial class BillControl : UserControl
    {
        int VehicleClick;
        frmHoatDongChoThue FrmHoatDongChoThue;
        BillDTO bill;
        BillDetailDTO billDetail;
        int TotalFee = 0;
        public BillControl(int vehicleClick,frmHoatDongChoThue frmHoatDongChoThue)
        {
            InitializeComponent();
            this.VehicleClick = vehicleClick;
            this.FrmHoatDongChoThue = frmHoatDongChoThue;
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 2 ham update status vehicle, update status bill
            if (VehicleRentalBUS.UpdateRentalReturnDateBUS(billDetail.RentalID, DateTime.Now))
            {
                if (BillBUS.UpdateBillTotalFeeAndStatusBillBUS(billDetail.ID, TotalFee))
                {
                    if (VehicleBUS.SetStatusVehicleBUS(VehicleClick, "free"))
                    {
                        FrmHoatDongChoThue.loadVehicle();
                        FrmHoatDongChoThue.frmHoatDongChoThue_Load(sender, e);
                        MessageBox.Show("Thanh toán thành công");
                        frmThanhToan frmThanhToan = new frmThanhToan(BillShowBUS.GetBillShowByIdBillBUS(billDetail.ID));
                        frmThanhToan.ShowDialog();
                    }
                    else
                        MessageBox.Show("Thanh toán thất bại");
                }
            }
            else
                MessageBox.Show("Thanh toán thất bại");
        }

        private void BillControl_Load(object sender, EventArgs e)
        {
            billDetail = BillDetailBUS.GetBillDetailByVehicleIdBUS(VehicleClick);
            if (billDetail != null)
            {
                btnThanhToan.Visible = true;
                txtMaHoaDon.Text = billDetail.ID.ToString();
                txtGia.Text= billDetail.RentalFee.ToString();
                txtStaff.Text= billDetail.FullName.ToString();
                
               

                // xu li hien ngay
                TimeSpan daysCount = DateTime.Now-billDetail.BillDate ;
                int numberOfDays = (int)daysCount.TotalDays+1;
                txtDayCount.Text= numberOfDays.ToString();
                //
                txtCurentMoney.Text=billDetail.TotalFee.ToString();
                txtBillDate.Text = billDetail.BillDate.ToString();

                txtCurentMoney.Text = (numberOfDays * billDetail.RentalFee).ToString();
                TotalFee = int.Parse(txtCurentMoney.Text);
                lbThanhTien.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0} VND", TotalFee);
                
            }


        }

    }
}
