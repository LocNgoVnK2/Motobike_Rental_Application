using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXeMay.FormService
{
    public partial class VehicleShowStatus : UserControl
    {
        private VehicleDTO vehicle;
        private frmHoatDongChoThue frmHoatDong;
        public VehicleShowStatus(VehicleDTO vehicle,frmHoatDongChoThue frmHoatDong)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            this.frmHoatDong = frmHoatDong;

            
        }

  
        private void VehicleShowStatus_Load(object sender, EventArgs e)
        {
            lbTenXe.Text = vehicle.Model.ToString(); 
            if (vehicle.Status == "free")
            {
                icPicXe.IconColor = System.Drawing.Color.White;
            }
            else
            {
                icPicXe.IconColor = System.Drawing.Color.Red;
            }
        }

        private void icPicXe_Click(object sender, EventArgs e)
        {
            
            frmHoatDong.txtBangSo.Text = vehicle.LicensePlate.ToString();
            frmHoatDong.txtHang.Text = vehicle.Brand.ToString();
            frmHoatDong.txtChiPhi.Text = vehicle.RentalFee.ToString();
            frmHoatDong.VehicleClick = vehicle.Id;
            frmHoatDong.frmHoatDongChoThue_Load(sender, e);
        }
    }
}
