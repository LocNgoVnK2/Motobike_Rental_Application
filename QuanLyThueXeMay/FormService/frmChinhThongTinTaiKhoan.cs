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
    public partial class frmChinhThongTinTaiKhoan : Form
    {
        private UserDTO loginAccount;
        private Main main;
      
        public frmChinhThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        public frmChinhThongTinTaiKhoan(UserDTO loginAccount, Main main)
        {
            InitializeComponent();
            this.loginAccount = loginAccount;
            this.main = main;
        }

      

        private void frmChinhThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

            //load ảnh
            this.loginAccount = UserBUS.getAccountBUS(loginAccount.Username);
            mainPic.Image = FormService.LoadImage(loginAccount);
            txtFullName.Text = loginAccount.FullName;
            txtUserName.Text = loginAccount.Username;
            txtPhoneNumber.Text = loginAccount.PhoneNumber; 
            
            
        }

   

        private void btnXacNhanAnh_Click(object sender, EventArgs e)
        {
            byte[] file_byte = FormService.ImageToByteArray(mainPic.Image);
            if (UserBUS.UpdateImageBUS(file_byte, loginAccount))
            {
                main.Main_Load(sender, e);
                MessageBox.Show("Thay đổi ảnh đại diện thành công!!", "Thong báo");
                frmChinhThongTinTaiKhoan_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thay đổi ảnh đại diện thất bại!!", "Thong báo");
            }
            btnXacNhanAnh.Visible = false;
        }

        private void mainPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    btnXacNhanAnh.Visible = true;
                    btnXacNhanAnh.Enabled = true;
                    
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
          
            string password = txtPassWord.Text;
            string repassword = txtRePassWord.Text;
            string fullname = txtFullName.Text;
            string phonenumber = txtPhoneNumber.Text;
       
            if (string.IsNullOrEmpty(txtPassWord.Text))
            {
                kiemTraCapNhat(loginAccount.Username, loginAccount.Password, fullname, phonenumber, sender, e);
            }
            else
            {
                if (password != repassword)
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp!", "Thông báo");
                }
                else
                {
                    kiemTraCapNhat(loginAccount.Username, password, fullname, phonenumber, sender, e);
                }
            }
        }
        private void kiemTraCapNhat(string username, string password, string fullname, string phonenumber, object sender, EventArgs e)
        {

        
                if (UserBUS.UpdateUserBUS(username, password, fullname, phonenumber))
                {
                    main.Main_Load(sender, e);
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo");
                }
            
         
        }
    }
}
