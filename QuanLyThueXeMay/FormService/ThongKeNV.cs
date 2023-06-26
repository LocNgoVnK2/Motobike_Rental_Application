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
    public partial class ThongKeNV : UserControl
    {
        public ThongKeNV()
        {
            InitializeComponent();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;
            dgvDoanhThuNV.DataSource = BillShowBUS.GetHighestIncomeByStaffBUS(startDate, endDate);
        }
    }
}
