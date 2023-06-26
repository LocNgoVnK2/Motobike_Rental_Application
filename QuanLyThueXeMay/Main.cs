using BUS;
using DTO;
using FontAwesome.Sharp;
using QuanLyThueXeMay.FormService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace QuanLyThueXeMay
{
    public partial class Main : Form
    {
        private static UserDTO loginAccount;
        private LoginForm loginForm;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private int closeChoose=0; // để làm tàn hình form login

        public int CloseChoose { get => closeChoose; set => closeChoose = value; }
        public static UserDTO LoginAccount { get => loginAccount; private set => loginAccount = value; }

        public Main()
        {
          
            InitializeComponent();
      

        }
        public Main(UserDTO loginAccount,LoginForm loginForm)
        {
            InitializeComponent();
            Main.loginAccount = loginAccount;
            this.loginForm = loginForm;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 68);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButtun();
                currentBtn =(IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(232,241,242);

                currentBtn.ForeColor = Color.FromArgb(255, 128, 0);
                currentBtn.IconColor = Color.FromArgb(255, 128, 0);
                currentBtn.Font= new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                // LEFT BORDER BUTTON(panel)
                leftBorderBtn.BackColor = Color.FromArgb(255, 128, 0);
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }
        private void DisableButtun()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 204, 255);

                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                leftBorderBtn.Visible= false;



            }
        }
        public void Main_Load(object sender, EventArgs e)
        {
            Main.loginAccount = UserBUS.getAccountBUS(LoginAccount.Username);
            //bo ảnh
           
            imgUser.Region = Region.FromHrgn(FormService.FormService.CreateRoundRectRgn(0, 0, imgUser.Width, imgUser.Height, 60, 60));
           //load ảnh
            lbUsername.Text = LoginAccount.FullName;
             imgUser.Image = FormService.FormService.LoadImage(LoginAccount);
            if (LoginAccount.IsAdmin != true)
            {
                btnInvoiceStatistics.Visible = false;
                btnManageAccount.Visible = false;
                btnBill.Visible = false;
                btnSetUpAPP.Visible = false;
            }
            else
            {
                btnUpdateAccount.Visible = true;
                btnInvoiceStatistics.Visible = true;
                btnManageAccount.Visible = true;
                btnUpdateAccount.Visible = true;
                btnUserInformation.Visible = true;
                btnBill.Visible = true;
            }
           
        }


    

        // nút đăng xuất
        private void iconButton8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                loginForm.txtUser.Focus();
                loginForm.txtUser.Text = "";
                loginForm.txtPass.Text = "";
                this.Close();
                CloseChoose = 1;
            }

        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!=null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnUserInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Thông tin khách hàng";
            OpenChildForm(new FormService.frmThongTinNguoiDung(LoginAccount));
        }

        private void btnVehicleInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Thông tin xe";
            
            OpenChildForm( new frmThongTinXe(LoginAccount)) ;
        }

        private void btnRentalActivity_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Hoạt động cho thuê";
            OpenChildForm(new FormService.frmHoatDongChoThue(LoginAccount));
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Hóa đơn";
            OpenChildForm(new FormService.frmHoaDon());
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Liên lạc";
            OpenChildForm(new FormService.frmLienLac(LoginAccount));
        }

        private void btnInvoiceStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Báo cáo thống kê";
            OpenChildForm(new FormService.frmBaoCaoThongKe());
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Quản lí tài khoản";
            OpenChildForm(new FormService.frmQuanLyTaiKhoan());
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Chỉnh sửa thông tin cá nhân";
            OpenChildForm(new FormService.frmChinhThongTinTaiKhoan(LoginAccount,this));
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)// dùng cho chuột kéo title bar
        {
           FormService.FormService.ReleaseCapture();
            FormService.FormService.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DisableButtun();
            lbTitleBar.Text = "Home";
            if (currentChildForm != null)
            currentChildForm.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
            CloseChoose = 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSetUpAPP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lbTitleBar.Text = "Thống kê doanh thu";
            OpenChildForm(new FormService.frmSetUpApplication());
        }


        private void SetDarkMode()
        {
            this.BackColor = Color.FromArgb(30, 30, 30); // đặt màu nền cho form
            panelUserInfor.BackColor = Color.FromArgb(30, 30, 30);
            panelTitleBar.BackColor = Color.FromArgb(30, 30, 30);

        }
        private void SetLightMode()
        {
            this.BackColor = Color.White; // đặt màu nền cho form
            panelUserInfor.BackColor = Color.FromArgb(51, 204, 255);
            panelTitleBar.BackColor = Color.FromArgb(51, 204, 255);
        }

        private void ckSangToi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckSangToi.Checked)
            {
                SetDarkMode();
            }
            else
            {
                SetLightMode();
            }

        }
    }
}
