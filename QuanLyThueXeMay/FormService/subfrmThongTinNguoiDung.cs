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
    public partial class subfrmThongTinNguoiDung : Form
    {
        private CustomerDTO customer=null;
        frmThongTinNguoiDung frmNguoiDung = null;
        public subfrmThongTinNguoiDung(frmThongTinNguoiDung frmNguoiDung)
        {
            InitializeComponent();
            btnLuu.Text = "Lưu";
            lbTitle.Text = "Khách hàng mới";
            this.frmNguoiDung = frmNguoiDung;
        }
        public subfrmThongTinNguoiDung(CustomerDTO customer, frmThongTinNguoiDung frmNguoiDung)
        {
            InitializeComponent();
            btnLuu.Text = "Cập nhật";
            lbTitle.Text = "Cập nhật thông tin";
            this.customer = customer;
            this.frmNguoiDung = frmNguoiDung;

            txtAddress.Text = customer.Address;
            txtDriverLicenseNumber.Text = customer.DriverLicenseNumber;
            txtEmail.Text = customer.Email;
            txtFullName.Text = customer.FullName;
            txtIdentityCardNumber.Text = customer.IdentityCardNumber;
            txtPhoneNumber.Text = customer.PhoneNumber;
            

        }
        void showError( string errorName)
        {
            label8.Text = errorName;
            pnThongBao.Visible = true;
        }
        void closeError()
        {
          
            pnThongBao.Visible = false;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtDriverLicenseNumber.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            txtIdentityCardNumber.Clear();
            txtPhoneNumber.Clear();
        }

  

        private void subfrmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            
         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string identityCardNumber = txtIdentityCardNumber.Text;
            string driverLicenseNumber = txtDriverLicenseNumber.Text;
            if (!string.IsNullOrEmpty(fullName) && !string.IsNullOrEmpty(phoneNumber) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(identityCardNumber) && !string.IsNullOrEmpty(driverLicenseNumber))
            {
                // Các biến đều có giá trị, tiếp tục thực hiện các xử lý
                if (customer == null)
                {
                    if (CustomerBUS.InsertCustomerBUS(fullName, phoneNumber, email, address, identityCardNumber, driverLicenseNumber))
                    {
                        frmNguoiDung.frmThongTinNguoiDung_Load(sender, e);
                    }
                    else
                    {
                        showError("Khách hàng đã có trong danh sách");
                    }
                }
                else
                {
                    int id = customer.Id;
                    //cap nhat
                    if (CustomerBUS.UpdateCustomerBUS(id,fullName, phoneNumber, email, address, identityCardNumber, driverLicenseNumber))
                    {
                        frmNguoiDung.frmThongTinNguoiDung_Load(sender, e);
                    }
                    else
                    {
                        showError(id.ToString());
                    }
                }
            }
            else
            {
                // Có ít nhất một biến bị thiếu giá trị, thông báo cho người dùng hoặc xử lý tương ứng
                showError("Vui lòng nhập đủ các trường");
            }
          
        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnThongBao.Visible = false;
        }

        
        private void txtDriverLicenseNumber_TextChanged(object sender, EventArgs e)
        {
            // khi điền chữ vào sẽ tắt thông báo cho cả 6 trường
            pnThongBao.Visible = false;
        }
    }
}
