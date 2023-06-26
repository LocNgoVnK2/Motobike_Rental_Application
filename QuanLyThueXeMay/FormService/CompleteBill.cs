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
    public partial class CompleteBill : UserControl
    {
        BillShowDTO billShow;
        public CompleteBill(BillShowDTO billShow)
        {
            InitializeComponent();
            this.BillShow = billShow;
        }

        public BillShowDTO BillShow { get => billShow; set => billShow = value; }

        private void CompleteBill_Load(object sender, EventArgs e)
        {
            txtDonGia.Text = string.Format("{0:N0} VND", Int32.Parse(BillShow.DonGia.ToString()));
            txtMaHoaDon.Text = BillShow.MaHoaDon.ToString();
            txtNgayLapPhieu.Text= BillShow.NgayLap.ToString();
            txtNgayThue.Text= BillShow.NgayThue.ToString();
            txtNgayTra.Text = BillShow.NgayTra.ToString();
            txtNhanVienLP.Text=BillShow.NVLapPhieu.ToString();
            txtTenKhachHang.Text = BillShow.TenKhachHang.ToString();
            txtTenXe.Text = BillShow.TenXe.ToString();
            lbTongThanhTien.Text = string.Format("{0:N0} VND", Int32.Parse(BillShow.TongTien.ToString())); 
        }
    }
}
