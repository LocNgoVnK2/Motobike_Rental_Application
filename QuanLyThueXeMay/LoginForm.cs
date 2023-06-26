using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXeMay
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Flash flash = new Flash();
            flash.ShowDialog();
            InitializeComponent();
            // làm tròn cái panel1
            
            panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(FormService.FormService.CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30));
            

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(FormService.FormService.CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username= txtUser.Text;
            string password = txtPass.Text;

            if(UserBUS.checkAccountBUS(username, password))
            {
                UserDTO loginAccount = UserBUS.getAccountBUS(username);
                Main main = new Main(loginAccount,this);
                
                this.Hide();
           
                main.ShowDialog();
                if(main.CloseChoose ==2)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông Báo");
            }
        }

        private void ckbHienThiPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiPass.Checked)
            {
                txtPass.PasswordChar = '\0'; // Hiển thị chuỗi ban đầu
            }
            else
            {
                txtPass.PasswordChar = '*'; // Mật khẩu bị ẩn
            }
        }
     

    }
}
