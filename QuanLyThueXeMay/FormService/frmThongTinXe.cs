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
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmThongTinXe : Form
    {
        DataTable dt;
        UserDTO userDTO;
        public frmThongTinXe(UserDTO userDTO)
        {
            InitializeComponent();
            this.userDTO = userDTO;
        }
        
        public void frmThongTinXe_Load(object sender, EventArgs e)
        {
            if (userDTO.IsAdmin == false) {
                btnThem.Visible = false;

            }
            else
            {
                btnThem.Visible = true;
            }
          
            panelVehicle.Controls.Clear();
        
            dt = VehicleBUS.GetAllVehicleBUS();
            
            foreach (DataRow row in dt.Rows)
            {
                panelVehicle.Refresh();

                VehicleDTO vehicle = new VehicleDTO(row);
      
                // Tạo một UserControl mới và truyền giá trị từ DataRow vào constructor
                var vehicleCard = new VehicleCard(vehicle,this,userDTO);

                // Thêm UserControl mới vào FlowLayoutPanel
                panelVehicle.Controls.Add(vehicleCard);
            }

        }
      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();

            foreach (VehicleCard card in panelVehicle.Controls.OfType<VehicleCard>())
            {
                if (card.Vehicle.Brand.ToLower().Contains(searchValue) ||
                    card.Vehicle.Model.ToLower().Contains(searchValue) ||
                    card.Vehicle.Color.ToLower().Contains(searchValue) ||
                    card.Vehicle.LicensePlate.ToLower().Contains(searchValue) ||
                    card.Vehicle.CategoryName.ToLower().Contains(searchValue))
                {
                    card.Visible = true;
                }
                else
                {
                    card.Visible = false;
                }
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new subfrmThongTinXe(this).ShowDialog();
        }
    }
}
