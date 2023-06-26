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
    public partial class frmHoatDongChoThue : Form
    {
        private int vehicleClick=1;
        public int VehicleClick { get => vehicleClick; set => vehicleClick = value; }

        private CheckingServiceVehicleDTO currentVehicle = null;

        private DataTable dtCustomer;

        private DataRow oldCustomer = null;

     

        private UserDTO curentUser;

        BillControl Bill=null;


        public frmHoatDongChoThue(UserDTO curentUser)
        {
            InitializeComponent();
             loadVehicle();
            ComboBox_Load();
            this.curentUser = curentUser;
        }

        //Nhóm Load các xe
        public void loadVehicle()
        {
            fpnLoadVehicles.Controls.Clear();
            List<VehicleDTO> list = VehicleBUS.loadVehicleListBUS();
            foreach (VehicleDTO vehicle in list)
            {
                VehicleShowStatus vehicleShow = new VehicleShowStatus(vehicle,this);
             
                fpnLoadVehicles.Controls.Add(vehicleShow);
            }


        }
        // load các thông tin đi kèm hóa đơn như là tt khách hàng 
        public void frmHoatDongChoThue_Load(object sender, EventArgs e)
        {
          
            currentVehicle = CheckingServiceVehicleBUS.CheckingServiceBUS(vehicleClick);
            // load Bill
           
            if (vehicleClick != 1)
            {
                foreach (Control c in panel2.Controls)
                {
                    if (c is BillControl)
                    {
                        panel2.Controls.Remove(c);
                    }
                }
                //BillControl = new BillControl(vehicleClick,this);
                Bill = new BillControl(vehicleClick, this);
                Bill.Dock = DockStyle.Bottom;
                panel2.Controls.Add(Bill);

            }
            if (currentVehicle != null) {
                txtFullName.Text = currentVehicle.FullName;
                txtSoDT.Text = currentVehicle.PhoneNumber;
                txtEmail.Text = currentVehicle.Email;
                txtDiaChi.Text = currentVehicle.Address;
                txtCanCuoc.Text = currentVehicle.IdentityCardNumber;
                txtBangLai.Text = currentVehicle.DriverLicenseNumber;
                txtMaND.Text= currentVehicle.CustomerID.ToString();
                dtpNgayThue.Value= currentVehicle.RentalDate;
               

                lbTrong.Visible = false;

                txtFullName.Enabled = false;
                txtSoDT.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                txtMaND.Enabled = false;
              
                txtCanCuoc.Enabled = false;
                txtBangLai.Enabled = false;
                btnThue.Visible = false;
                ckbKhachCu.Visible = false;
                
            }
            else
            {
                
                txtFullName.Text = "";
                txtSoDT.Text = "";
                txtEmail.Text = "";
                txtDiaChi.Text = "";
                txtMaND.Text = "";
               
                txtCanCuoc.Text = "";
                txtBangLai.Text = "";
                dtpNgayThue.Value = DateTime.Now;
                ckbKhachCu.Visible = false;
                if (vehicleClick != 1)
                {

                    ckbKhachCu.Visible = true;
                   
                    lbTrong.Visible = true;
                    btnThue.Visible = true;

                    txtFullName.Enabled = true;
                    txtSoDT.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDiaChi.Enabled = true;
                    
                    
                    txtCanCuoc.Enabled = true;
                    txtBangLai.Enabled = true;
                }

            }
        }
        public void ComboBox_Load()
        {
            dtCustomer = CustomerBUS.GetAllCustomerBUS();
            cbMaND.DataSource = dtCustomer;
            cbMaND.DisplayMember = "Id";
            cbMaND.ValueMember = "Id";
           
        }
       
        
    // nhóm xử lí việc chọn khách cũ

        private void ckbKhachCu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbKhachCu.Checked != true)
            {
                gbKhachCu.Visible = false;
  
                
            }
            else
            {
                gbKhachCu.Visible = true;
                oldCustomer = GetCustomerById((int)cbMaND.SelectedValue, dtCustomer);

            }
        }
        public static DataRow GetCustomerById(int id, DataTable dtCustomer)
        {
            DataRow[] rows = dtCustomer.Select("Id = " + id);
            if (rows.Length > 0)
            {
                return rows[0];
            }
            else
            {
                return null;
            }
            
        }

        private void cbMaND_SelectedIndexChanged(object sender, EventArgs e)
        {
            ckbKhachCu_CheckedChanged(sender, e);
            if (oldCustomer!=null)
            {
                txtMaND.Text = "";

                txtMaND.Text= oldCustomer[0].ToString();
                txtFullName.Text = oldCustomer[1].ToString();
                txtSoDT.Text = oldCustomer[2].ToString();
                txtEmail.Text = oldCustomer[3].ToString();
                txtDiaChi.Text = oldCustomer[4].ToString();
                txtCanCuoc.Text = oldCustomer[5].ToString();
                txtBangLai.Text = oldCustomer[6].ToString();
            }
           

        }

        // thực hiện tạo hóa đơn thê Nút thanh toán nằm ở cái bill thì trong UserControl Bill

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtSoDT.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtCanCuoc.Text) ||
                string.IsNullOrEmpty(txtBangLai.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ các trường");
            }
            else
            {
                ckbKhachCu.Visible= false;
                gbKhachCu.Visible= false;
                if (dtCustomer.AsEnumerable().Any(row => row.Field<string>("identityCardNumber") == txtCanCuoc.Text))
                {
                    // thông báo sử dụng chức năng khác hàng cũ 
                    DateTime thatDay = DateTime.Now;
                    
                    
                    CreateBill(int.Parse(txtMaND.Text), VehicleClick, thatDay);
                    this.frmHoatDongChoThue_Load(sender, e);
                    
                }
                else
                {
                    // lưu hóa đơn

                    //b1 nếu khách mới thì lưu khác này vào 

                    if (CustomerBUS.InsertCustomerBUS(txtFullName.Text, txtSoDT.Text, txtEmail.Text, txtDiaChi.Text, txtCanCuoc.Text, txtBangLai.Text))
                    {
                        CustomerDTO curentCustomer = CustomerBUS.GetUserByIdentityCardNumberDAO(txtCanCuoc.Text);
                        txtMaND.Text = curentCustomer.Id.ToString();
                        txtFullName.Text = curentCustomer.FullName;
                        txtSoDT.Text = curentCustomer.PhoneNumber;
                        txtEmail.Text = curentCustomer.Email;
                        txtDiaChi.Text = curentCustomer.Address;
                        txtCanCuoc.Text = curentCustomer.IdentityCardNumber;
                        txtBangLai.Text = curentCustomer.DriverLicenseNumber;

                        // lưu hóa đơn
                    
                        
                        DateTime thatDay = DateTime.Now;

                        CreateBill(curentCustomer.Id, VehicleClick, thatDay);
                                 

                    }
                    else
                    {
                        MessageBox.Show("Có vấn đề gì đó với thông tin khách hàng voi lòng kiểm tra lại!");
                    }

                    this.frmHoatDongChoThue_Load(sender, e);
                }
            }
        }
        public void CreateBill(int customerId,int VehicleId, DateTime VehicleDate )
        {
            VehicleRentalDTO currentVR = null;
            //b1 tạo vào Vehicle rental 
            if (VehicleRentalBUS.InsertVehicleRentalBUS(customerId, VehicleId, VehicleDate))
            {
                currentVR = VehicleRentalBUS.GetCurrentVehicleRentalBUS();
            }
          
            //b2 tạo vào bill
            if (BillBUS.InsertBillBUS(DateTime.Now, curentUser.Id, currentVR.ID))
            {
                //b3 set xe đó status ='busy'
                if (VehicleBUS.SetStatusVehicleBUS(vehicleClick, "busy"))
                {
                    loadVehicle();
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
        }

     
    }
}
