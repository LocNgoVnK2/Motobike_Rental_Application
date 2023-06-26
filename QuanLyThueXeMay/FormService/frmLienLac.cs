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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmLienLac : Form
    {
       
        UserDTO currentAccount = null;
        public frmLienLac(UserDTO currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
        
        }


        public void TinNhanLoad()
        {
            //khi nhận tin nhắn thì mình đóng vai người nhận , người gửi  thì là sender
            if (cbTuNguoiDung.SelectedValue != null)
            {
                int senderId = (int)cbTuNguoiDung.SelectedValue;
                int recipientId = currentAccount.Id;
                List<ContactDTO> contacts = ContactBUS.GetAllMessageByIdBUS(senderId, recipientId);
                flpTinNhan.Controls.Clear();
                foreach(ContactDTO contact in contacts) 
                {
                    flpTinNhan.Controls.Add(new UserControlSupport.MessageControl(contact,this));
                }
                flpTinNhan.VerticalScroll.Value = flpTinNhan.VerticalScroll.Maximum;
            }

        }


        private void frmLienLac_Load(object sender, EventArgs e)
        {
            cbTuNguoiDung.DataSource = UserBUS.GetAllUserWithIDAndFullnameBUS();
            cbTuNguoiDung.DisplayMember = "FullName";
            cbTuNguoiDung.ValueMember = "ID";
            cbTuNguoiDung.SelectedIndex = -1; // Chọn item mặc định là null

            if (cbTuNguoiDung.SelectedIndex == -1)
            {
                txtNoiDungGui.Enabled = false;
            }
        }




        private void cbTuNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTuNguoiDung.SelectedValue is DataRowView)
            {
                return;
            }
            txtNoiDungGui.Enabled=true;
            TinNhanLoad();
        }

        //int shiftEnterCount = 0;
        private void txtNoiDungGui_KeyDown(object sender, KeyEventArgs e)
        {
            int shiftEnterCount = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                {
                    shiftEnterCount++;
                }
                else
                {
                    // Xử lý khi nhấn enter bình thường
                    // lúc này người đang sài tk là người gửi
                    MessageBUS.InsertMessageBUS(currentAccount.Id, (int)cbTuNguoiDung.SelectedValue, txtNoiDungGui.Text, DateTime.Now);
                        txtNoiDungGui.Clear();
                        txtNoiDungGui.Focus();
                    TinNhanLoad();
                }
            }
            else if (e.KeyCode != Keys.ShiftKey)
            {
                // Reset lại biến đếm nếu người dùng không gõ shift
                shiftEnterCount = 0;
            }
         
        }
    }
}
