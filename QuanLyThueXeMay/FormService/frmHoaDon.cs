using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
            LoadBill();
            DateTime homTruoc = DateTime.Now.AddDays(-1);
            dtpNgayBatDau.Value = homTruoc;

        }
        private void LoadBill()
        {
            flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().OrderByDescending(bill => bill.NgayTra).ToList();// cú pháp của linq sắp sếp giảm dần
            foreach(BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);
           
                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }
            
        }
 
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            
        }

     

        private void btnNgayCuNhat_Click(object sender, EventArgs e)
        {
            flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().ToList();// cú pháp của linq sắp sếp giảm dần
            foreach (BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);

                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }

        }

        private void btnGiaCaoNhat_Click(object sender, EventArgs e)
        {
            flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().OrderByDescending(bill => bill.TongTien).ToList();// cú pháp của linq sắp sếp giảm dần
            foreach (BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);

                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }
        }

        private void btnGiaThapNhat_Click(object sender, EventArgs e)
        {
               flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().OrderBy(bill => bill.TongTien).ToList();// cú pháp của linq sắp sếp tăng dần
            foreach (BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);

                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }
        }

        private void btnNgayMoiNhat_Click(object sender, EventArgs e)
        {
            flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().OrderByDescending(bill => bill.NgayLap).ToList();// cú pháp của linq sắp sếp giảm dần
            foreach (BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);

                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }
        }

        private void btnLocNgay_Click(object sender, EventArgs e)
        {

            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            flpHoaDon.Controls.Clear();
            List<BillShowDTO> billShows = BillShowBUS.GetAllBillBUS().Where(bill => bill.NgayLap.Date >= ngayBatDau && bill.NgayLap.Date <= ngayKetThuc).ToList();// cú pháp của linq sắp sếp giảm dần
            foreach (BillShowDTO billShow in billShows)
            {
                CompleteBill bill = new CompleteBill(billShow);

                bill.Margin = new Padding(20, 20, 20, 40);
                flpHoaDon.Controls.Add(bill);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTim.Text.ToLower();

           
            foreach (CompleteBill bill in flpHoaDon.Controls.OfType<CompleteBill>())
            {
                bool match = false;
                if (bill.BillShow.TenKhachHang.ToLower().Contains(searchValue) ||
                bill.BillShow.TongTien.ToString().ToLower().Contains(searchValue) ||
                bill.BillShow.TenXe.ToLower().Contains(searchValue) ||
                bill.BillShow.TenKhachHang.ToLower().Contains(searchValue) ||
                bill.BillShow.NVLapPhieu.ToLower().Contains(searchValue) ||
                bill.BillShow.MaHoaDon.ToString().ToLower().Contains(searchValue))
                {
                    match = true;
                }

                bill.Visible = match;
            }
        }

        private void btnXeSDNhieu_Click(object sender, EventArgs e)
        {
            flpHoaDon.Controls.Clear();
            flpHoaDon.Controls.Add(new ThongKeXe());

        }

        private void btnNhanVienDT_Click(object sender, EventArgs e)
        {
            flpHoaDon.Controls.Clear();
            flpHoaDon.Controls.Add(new ThongKeNV());
        }
    }
}
