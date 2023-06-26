using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'motoBikeRentalDataSet.BillShow1' table. You can move, or remove it, as needed.
            this.billShow1TableAdapter.Fill(this.motoBikeRentalDataSet.BillShow1);

            this.reportViewer1.RefreshReport();
           
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

            DataTable dt = BillShowBUS.GetBillShowBetweenStartDateAndEndDateBUS(StartDate.Value, EndDate.Value);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1",dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();



        }
    
    
    }
}
