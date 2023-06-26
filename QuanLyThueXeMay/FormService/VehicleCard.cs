using BUS;
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
    public partial class VehicleCard : UserControl
    {
        private VehicleDTO vehicle ;
        private frmThongTinXe frmThongTinXe;
        UserDTO userDTO;

        public VehicleDTO Vehicle { get => vehicle; set => vehicle = value; }

        public VehicleCard(VehicleDTO Vehicle, frmThongTinXe frmThongTinXe,UserDTO userDTO)
        {
            InitializeComponent();

            this.Vehicle = Vehicle;
            this.userDTO = userDTO;

            mainPanel.Region = Region.FromHrgn(FormService.CreateRoundRectRgn(0, 0, mainPanel.Width, mainPanel.Height, 30, 30));
            btnSua.Region = Region.FromHrgn(FormService.CreateRoundRectRgn(0, 0, btnSua.Width, btnSua.Height, 30, 30));
            btnXoa.Region = Region.FromHrgn(FormService.CreateRoundRectRgn(0, 0, btnXoa.Width, btnXoa.Height, 30, 30));
            
            this.DoubleBuffered = true;
            this.Anchor = AnchorStyles.None;
            this.Dock = DockStyle.None;
            
            this.frmThongTinXe = frmThongTinXe;
        }

  

        public void VehicleCard_Load(object sender, EventArgs e)
        {
            txtBrand.Text = Vehicle.Brand;
            txtColor.Text = Vehicle.Color;
            txtlicensePlate.Text = Vehicle.LicensePlate;
            txtModel.Text = Vehicle.Model;
            txtLoaiXe.Text = Vehicle.CategoryName;
            txtRentalFee.Text = Vehicle.RentalFee.ToString() + " VND/Day";
            imgXe.Image = FormService.LoadImageVehicle(Vehicle);

            if (userDTO.IsAdmin == false)
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;

            }
            else
            {
                btnSua.Visible = true;
                btnXoa.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new subfrmThongTinXe(Vehicle, frmThongTinXe).ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (VehicleBUS.DeleteVehicleBUS(vehicle.Id))
            {
                frmThongTinXe.frmThongTinXe_Load(sender,e);
            }
        }
    }
}
