using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        private enum ActionType
        {
            Add,
            Edit
        }
        ActionType action;
        private class ComboBoxSupport
        {
            string headerText;
            string name;

            public string HeaderText { get => headerText; set => headerText = value; }
            public string Name { get => name; set => name = value; }
        }

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }


        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = UserBUS.GetAllUserAccountBUS();
           
          // TỪ Từ NGHIÊN CỨU
          
            
           
            //chặn click vào đổi ảnh chỉ có chức năng thêm admin mới được phép dử dụng
            picAnhDaiDien.Enabled = false;

            
            clearBinDings();
            addBinDings();
            
        }
        private void addBinDings()
        {
            
            txtMaNV.DataBindings.Add("text", dgvTaiKhoan.DataSource, "ID");
            txtUserName.DataBindings.Add("text", dgvTaiKhoan.DataSource, "Username");
            txtPassWord.DataBindings.Add("text", dgvTaiKhoan.DataSource, "Password");
            txtPhoneNumber.DataBindings.Add("text", dgvTaiKhoan.DataSource, "PhoneNumber");
            cbQuyen.DataBindings.Add("SelectedIndex", dgvTaiKhoan.DataSource, "IsAdmin");
            txtFullName.DataBindings.Add("text", dgvTaiKhoan.DataSource, "FullName");
            picAnhDaiDien.DataBindings.Add("Image", dgvTaiKhoan.DataSource, "Image",true);
        }
        void clearBinDings()
        {
            txtMaNV.DataBindings.Clear();
            txtUserName.DataBindings.Clear();
            txtPassWord.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Clear();
            cbQuyen.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            picAnhDaiDien.DataBindings.Clear();
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string searchValue = txtSearchValue.Text;
            DataTable dt = UserBUS.GetAllUserAccountBUS();
            foreach (DataRow row in dt.Rows)
            {
                string userName = row["Username"].ToString();
                string fullName = row["FullName"].ToString();
                string phoneNumber = row["PhoneNumber"].ToString();

                if (userName.Contains(searchValue)
                    || fullName.Contains(searchValue)
                    || phoneNumber.Contains(searchValue))
                {
                    txtUserName.Text = userName;
                    txtPassWord.Text = row["Password"].ToString();
                    txtPhoneNumber.Text = phoneNumber;
                    txtFullName.Text = fullName;
                    bool isAdmin = (bool)row["IsAdmin"];
                    cbQuyen.SelectedIndex = isAdmin ? 1 : 0;
                    picAnhDaiDien.Image = FormService.ByteArrayToImage((byte[])row["Image"]);
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy tài khoản nào phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtUserName.Clear();
            txtPhoneNumber.Clear();
            txtPassWord.Clear();
            txtMaNV.Clear();

            txtFullName.Enabled = true;
            txtUserName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtPassWord.Enabled = true;
            cbQuyen.Enabled = true;



            cbQuyen.SelectedIndex = 0;
            if (picAnhDaiDien.Image != null)
            {
                picAnhDaiDien.Image.Dispose();
                picAnhDaiDien.Image = null;
            }
            picAnhDaiDien.Image= global::QuanLyThueXeMay.Properties.Resources._4333097;

            picAnhDaiDien.Enabled = true;
            clearBinDings();
            btnCapNhat.Enabled = true;
            btnTimKiem.Enabled = false;
            btnXoa.Enabled = false;
            btnChinh.Enabled = false;

            action = ActionType.Add;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // mở các control
            txtFullName.Enabled = false;
            txtUserName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtPassWord.Enabled = false;
            cbQuyen.Enabled = false;
            picAnhDaiDien.Enabled=false;

            btnTimKiem.Enabled = true;
            btnXoa.Enabled = true;
            btnThemMoi.Enabled = true;
            btnChinh.Enabled = true;
            btnCapNhat.Enabled=false;
            frmQuanLyTaiKhoan_Load(sender, e);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (action == ActionType.Add)
                CreateAcccout(sender, e);
            else
                UpdateAcccout( sender,  e);
        }
        private void UpdateAcccout(object sender, EventArgs e)
        {

            // chưa làm ràng buộc trường . chưa load lại form
            int manv =  Convert.ToInt32(txtMaNV.Text);
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassWord.Text;
            bool isAdmin = cbQuyen.SelectedIndex == 0 ? false:true;            // Lấy giá trị từ ComboBox

            byte[] file_byte = FormService.ImageToByteArray(picAnhDaiDien.Image);
            if (fullName == "" || userName == "" || phoneNumber == "" || password == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ các thông tin cần thiết", "Thông báo");
            }
            else
            {
                if (UserBUS.UpdateUserBUS(manv,userName, password, fullName, phoneNumber, isAdmin, file_byte))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");

                    txtFullName.Enabled = false;
                    txtUserName.Enabled = false;
                    txtPhoneNumber.Enabled = false;
                    txtPassWord.Enabled = false;
                    cbQuyen.Enabled = false;
                    btnCapNhat.Enabled = false;

                    btnTimKiem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnChinh.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
                frmQuanLyTaiKhoan_Load(sender, e);
            }

        }
        private void CreateAcccout(object sender, EventArgs e)
        {
            
            // chưa làm ràng buộc trường . chưa load lại form
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassWord.Text;
            int isAdmin = cbQuyen.SelectedIndex; // Lấy giá trị từ ComboBox
            byte[] file_byte = FormService.ImageToByteArray(picAnhDaiDien.Image);
            if (fullName == "" || userName == "" || phoneNumber == "" || password == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ các thông tin cần thiết", "Thông báo");
            }
            else
            {
                if (UserBUS.InsertUserAccountBUS(userName, password, fullName, phoneNumber, isAdmin, file_byte))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");

                    txtFullName.Enabled = false;
                    txtUserName.Enabled = false;
                    txtPhoneNumber.Enabled = false;
                    txtPassWord.Enabled = false;
                    cbQuyen.Enabled = false;
                    btnCapNhat.Enabled = false;

                    btnTimKiem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnChinh.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                }
                frmQuanLyTaiKhoan_Load(sender, e);
            }

        }
        private void picAnhDaiDien_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picAnhDaiDien.Image = new Bitmap(open.FileName);
                // image file path  
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(txtMaNV.Text);
            if (UserBUS.DeleteUserBUS(manv))
            {
                frmQuanLyTaiKhoan_Load(sender, e);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btnChinh_Click(object sender, EventArgs e)
        {
            // mở các control
            txtFullName.Enabled = true;
            txtUserName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtPassWord.Enabled = true;
            cbQuyen.Enabled = true;
            picAnhDaiDien.Enabled = true;
            // đóng các nút ko đucọ sử dụng trong quá trình chỉnh tt
     
            btnCapNhat.Enabled = true;
            btnTimKiem.Enabled = false;
            btnXoa.Enabled = false;
            btnThemMoi.Enabled = false;


            action = ActionType.Edit;
            btnCapNhat.Enabled = true;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null) // assuming the boolean column is at index 2
            {
                bool isAdmin = (bool)e.Value;
                e.Value = isAdmin ? "Quản lý" : "Nhân viên";
                e.FormattingApplied = true;
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5) // Kiểm tra nếu cột đang được hiển thị là cột isAdmin (cột thứ 5)
            {
                if (e.Value != null && (bool)e.Value) // Kiểm tra giá trị của ô đó
                {
                    e.Value = "Quản lý";
                }
                else
                {
                    e.Value = "Nhân viên";
                }
                e.FormattingApplied = true; // Đánh dấu đã thực hiện formatting cho ô đó
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
