using BUS;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXeMay.FormService
{
    public partial class frmThanhToan : Form
    {
        DataTable thisBill;
        public frmThanhToan(DataTable thisBill)
        {
            InitializeComponent();
            this.thisBill = thisBill;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = thisBill;


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bs));

            // Refresh ReportViewer
            reportViewer1.RefreshReport();

           
        }
    }
}
