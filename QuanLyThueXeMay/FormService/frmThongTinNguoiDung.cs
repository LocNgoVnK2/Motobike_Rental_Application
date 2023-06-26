using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmThongTinNguoiDung : Form
    {
        UserDTO loginAccount;
     
        public frmThongTinNguoiDung(UserDTO loginAccount)
        {
            InitializeComponent();
            this.loginAccount = loginAccount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new subfrmThongTinNguoiDung(this).ShowDialog();
        }
       

        public void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = CustomerBUS.GetAllCustomerBUS();
            if (loginAccount.IsAdmin == false)
            {
                button1.Visible = false;
                dgvCustomer.Columns["edit"].Visible = false;
                dgvCustomer.Columns["delete"].Visible = false;
            }
           

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
    
                int id = (int)dgvCustomer.Rows[e.RowIndex].Cells["id"].Value;
                string fullName = dgvCustomer.Rows[e.RowIndex].Cells["fullName"].Value.ToString();
                string phoneNumber = dgvCustomer.Rows[e.RowIndex].Cells["phoneNumber"].Value.ToString();
                string email = dgvCustomer.Rows[e.RowIndex].Cells["email"].Value.ToString();
                string address = dgvCustomer.Rows[e.RowIndex].Cells["address"].Value.ToString();
                string identityCardNumber = dgvCustomer.Rows[e.RowIndex].Cells["identityCardNumber"].Value.ToString();
                string driverLicenseNumber = dgvCustomer.Rows[e.RowIndex].Cells["driverLicenseNumber"].Value.ToString();

                // Tạo đối tượng CustomerDTO mới từ các giá trị vừa lấy
                CustomerDTO selectedCustomer = new CustomerDTO(id, fullName, phoneNumber, email, address, identityCardNumber, driverLicenseNumber);

                // Mở form subfrmThongTinNguoiDung với đối tượng khách hàng tương ứng
                new subfrmThongTinNguoiDung(selectedCustomer,this).ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                // xoa bo
                try
                {
                    CustomerBUS.DeleteCustomerBUS((int)dgvCustomer.Rows[e.RowIndex].Cells["id"].Value);
                    frmThongTinNguoiDung_Load(sender, e);
                }catch(Exception ex)
                {
                    MessageBox.Show("không thể xóa khách hàng này");
                }

            }
         

        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomer.DataSource];
                currencyManager1.SuspendBinding();
                row.Visible = false;
                currencyManager1.ResumeBinding();
            }
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(searchValue))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvCustomer.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = true;
                        currencyManager1.ResumeBinding();
                    }
                }

            }
        }
    }
}
