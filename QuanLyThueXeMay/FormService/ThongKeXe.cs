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

namespace QuanLyThueXeMay.FormService
{
    public partial class ThongKeXe : UserControl
    {
        public ThongKeXe()
        {
            InitializeComponent();
        }

        private void ThongKeXe_Load(object sender, EventArgs e)
        {
          
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
          
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            DataTable table = BillShowBUS.GetHighestIncomFromVehicleBUS(startDate, endDate);
            dgvTopDanhThuXe.DataSource = table;
        }
    }
}
