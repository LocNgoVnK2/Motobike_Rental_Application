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
    public partial class subfrmThongTinXe : Form
    {
        VehicleDTO vehicle=null;
        frmThongTinXe fthongTinXe = null;

        public subfrmThongTinXe(frmThongTinXe fthongTinXe)
        {
            InitializeComponent();
            lbTitle.Text = "Thêm xe";
            this.fthongTinXe = fthongTinXe;
        }
        public subfrmThongTinXe( VehicleDTO vehicle, frmThongTinXe fthongTinXe)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            lbTitle.Text = "Chỉnh sửa thông tin xe";
            this.fthongTinXe = fthongTinXe;
        }

        private void subfrmThongTinXe_Load(object sender, EventArgs e)
        {
            cbLoaiXe.DataSource = CategoryBUS.GetCategoryBUS();
            cbLoaiXe.DisplayMember = "Name";
            cbLoaiXe.ValueMember = "ID";
            

            if (vehicle != null)
            {
                txtHangXe.Text=vehicle.Brand.ToString();
                txtDongXe.Text=vehicle.Model.ToString();
                txtMauSac.Text=vehicle.Color.ToString();
                txtBangSo.Text=vehicle.LicensePlate.ToString();
                txtChiPhi.Text=vehicle.RentalFee.ToString();
                cbLoaiXe.SelectedValue = vehicle.CategoryId;
                imgHinhXe.Image = FormService.LoadImageVehicle(vehicle);
            }
     
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       private void ThongBao(string Loi)
        {
            lbLoi.Text = Loi;
            pnThongBao.Visible = true;
        }

        private void ìmgHinhXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }
        private bool CheckControls()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtHangXe.Text))
            {
                result = false;
                ThongBao("Vui lòng nhập Hãng xe.");
                txtHangXe.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDongXe.Text))
            {
                result = false;
                ThongBao("Vui lòng nhập Dòng xe.");
                txtDongXe.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtMauSac.Text))
            {
                result = false;
                ThongBao("Vui lòng nhập Màu sắc xe.");
                txtMauSac.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtBangSo.Text))
            {
                result = false;
                ThongBao("Vui lòng nhập Biển số xe.");
                txtBangSo.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtChiPhi.Text) )
            {
                result = false;
                ThongBao("Vui lòng nhập Chi phí thuê xe.");
                txtChiPhi.Focus();
            }else if(!System.Text.RegularExpressions.Regex.IsMatch(txtChiPhi.Text, @"^\d+$"))
            {
                result = false;
                ThongBao("Vui lòng nhập Chi phí là một số thuê xe.");
                txtChiPhi.Focus();
            }

            return result;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
    
         
            if (CheckControls())
            {
                string brand = txtHangXe.Text;
                string model = txtDongXe.Text;
                string color = txtMauSac.Text;
                string licensePlate = txtBangSo.Text;
                int categoryID = Convert.ToInt32(cbLoaiXe.SelectedValue);
                byte[] vehiclePicture = FormService.ImageToByteArray(imgHinhXe.Image); // hàm lấy ảnh từ control PictureBox
                int rentalFee = Convert.ToInt32(txtChiPhi.Text);

                if (vehicle != null)
                {
                    int id = Convert.ToInt32(vehicle.Id);


                    if (VehicleBUS.UpdateVehicleBUS(id, brand, model, color, licensePlate, categoryID, vehiclePicture, rentalFee))
                    {

                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                       
                        fthongTinXe.frmThongTinXe_Load(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                    }
                }
                else
                {
                    if (VehicleBUS.AddVehicleBUS(brand, model, color, licensePlate, categoryID, vehiclePicture, rentalFee))
                    {

                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                        fthongTinXe.frmThongTinXe_Load(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                    }
                }
            }
        }

        private void lbLoi_TextChanged(object sender, EventArgs e)
        {
            pnThongBao.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnThongBao.Visible=false;
        }
    }
}
