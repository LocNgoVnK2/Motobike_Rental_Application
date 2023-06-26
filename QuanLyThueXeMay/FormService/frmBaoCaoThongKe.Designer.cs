namespace QuanLyThueXeMay.FormService
{
    partial class frmBaoCaoThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.billShow1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoBikeRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoBikeRentalDataSet = new QuanLyThueXeMay.MotoBikeRentalDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.billShow1TableAdapter = new QuanLyThueXeMay.MotoBikeRentalDataSetTableAdapters.BillShow1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.billShow1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBikeRentalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBikeRentalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // billShow1BindingSource
            // 
            this.billShow1BindingSource.DataMember = "BillShow1";
            this.billShow1BindingSource.DataSource = this.motoBikeRentalDataSetBindingSource;
            // 
            // motoBikeRentalDataSetBindingSource
            // 
            this.motoBikeRentalDataSetBindingSource.DataSource = this.motoBikeRentalDataSet;
            this.motoBikeRentalDataSetBindingSource.Position = 0;
            // 
            // motoBikeRentalDataSet
            // 
            this.motoBikeRentalDataSet.DataSetName = "MotoBikeRentalDataSet";
            this.motoBikeRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.billShow1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThueXeMay.Report.BussinessReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1565, 737);
            this.reportViewer1.TabIndex = 0;
            // 
            // billShow1TableAdapter
            // 
            this.billShow1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "TG cần xuất báo cáo";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Location = new System.Drawing.Point(1266, 7);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(195, 45);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc hóa đơn";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(294, 16);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(305, 29);
            this.StartDate.TabIndex = 4;
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.EndDate.Location = new System.Drawing.Point(788, 16);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(306, 29);
            this.EndDate.TabIndex = 8;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1565, 815);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmThongkeDoanhThu";
            this.Load += new System.EventHandler(this.frmBaoCaoThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billShow1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBikeRentalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBikeRentalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MotoBikeRentalDataSet motoBikeRentalDataSet;
        private System.Windows.Forms.BindingSource motoBikeRentalDataSetBindingSource;
        private System.Windows.Forms.BindingSource billShow1BindingSource;
        private MotoBikeRentalDataSetTableAdapters.BillShow1TableAdapter billShow1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker EndDate;
    }
}