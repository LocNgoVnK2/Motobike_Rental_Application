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

namespace QuanLyThueXeMay.FormService.UserControlSupport
{
    public partial class MessageControl : UserControl
    {
        ContactDTO contactDTO;
        frmLienLac frmLienLac;
        public MessageControl(ContactDTO contactDTO, frmLienLac frmLienLac)
        {
            InitializeComponent();
            this.contactDTO = contactDTO;
            this.frmLienLac = frmLienLac;
            txtContentMess.Enabled = false;
            txtNgayGui.Enabled = false;
         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
        {
            txtContentMess.Text = contactDTO.Content ;
            lbTen.Text = contactDTO.SenderFullName;
            txtNgayGui.Text = contactDTO.SentAt.ToString();
            


        }


        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBUS.DeleteMessageDAO(contactDTO.ID))
            {
                frmLienLac.TinNhanLoad();
            }
            
        }
    }
}
