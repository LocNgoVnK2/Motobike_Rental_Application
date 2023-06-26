namespace QuanLyThueXeMay.FormService
{
    partial class frmHoaDon
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
            this.flpHoaDon = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhanVienDT = new System.Windows.Forms.Button();
            this.btnXeSDNhieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLocNgay = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnGiaThapNhat = new System.Windows.Forms.Button();
            this.btnGiaCaoNhat = new System.Windows.Forms.Button();
            this.btnNgayCuNhat = new System.Windows.Forms.Button();
            this.btnNgayMoiNhat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpHoaDon
            // 
            this.flpHoaDon.AutoScroll = true;
            this.flpHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.flpHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpHoaDon.Location = new System.Drawing.Point(0, 89);
            this.flpHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.flpHoaDon.Name = "flpHoaDon";
            this.flpHoaDon.Padding = new System.Windows.Forms.Padding(50);
            this.flpHoaDon.Size = new System.Drawing.Size(1565, 726);
            this.flpHoaDon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnNhanVienDT);
            this.panel1.Controls.Add(this.btnXeSDNhieu);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnGiaThapNhat);
            this.panel1.Controls.Add(this.btnGiaCaoNhat);
            this.panel1.Controls.Add(this.btnNgayCuNhat);
            this.panel1.Controls.Add(this.btnNgayMoiNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1565, 110);
            this.panel1.TabIndex = 1;
            // 
            // btnNhanVienDT
            // 
            this.btnNhanVienDT.BackColor = System.Drawing.Color.White;
            this.btnNhanVienDT.FlatAppearance.BorderSize = 0;
            this.btnNhanVienDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVienDT.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVienDT.Location = new System.Drawing.Point(367, 55);
            this.btnNhanVienDT.Name = "btnNhanVienDT";
            this.btnNhanVienDT.Size = new System.Drawing.Size(358, 46);
            this.btnNhanVienDT.TabIndex = 13;
            this.btnNhanVienDT.Text = "Doanh thu nhân viên";
            this.btnNhanVienDT.UseVisualStyleBackColor = false;
            this.btnNhanVienDT.Click += new System.EventHandler(this.btnNhanVienDT_Click);
            // 
            // btnXeSDNhieu
            // 
            this.btnXeSDNhieu.BackColor = System.Drawing.Color.White;
            this.btnXeSDNhieu.FlatAppearance.BorderSize = 0;
            this.btnXeSDNhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXeSDNhieu.ForeColor = System.Drawing.Color.Black;
            this.btnXeSDNhieu.Location = new System.Drawing.Point(3, 55);
            this.btnXeSDNhieu.Name = "btnXeSDNhieu";
            this.btnXeSDNhieu.Size = new System.Drawing.Size(358, 46);
            this.btnXeSDNhieu.TabIndex = 12;
            this.btnXeSDNhieu.Text = "Xe SD nhiều nhất";
            this.btnXeSDNhieu.UseVisualStyleBackColor = false;
            this.btnXeSDNhieu.Click += new System.EventHandler(this.btnXeSDNhieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocNgay);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(810, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 101);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn trong khoản ngày";
            // 
            // btnLocNgay
            // 
            this.btnLocNgay.BackColor = System.Drawing.Color.White;
            this.btnLocNgay.FlatAppearance.BorderSize = 0;
            this.btnLocNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocNgay.ForeColor = System.Drawing.Color.Black;
            this.btnLocNgay.Location = new System.Drawing.Point(392, 54);
            this.btnLocNgay.Name = "btnLocNgay";
            this.btnLocNgay.Size = new System.Drawing.Size(83, 39);
            this.btnLocNgay.TabIndex = 12;
            this.btnLocNgay.Text = "Lọc";
            this.btnLocNgay.UseVisualStyleBackColor = false;
            this.btnLocNgay.Click += new System.EventHandler(this.btnLocNgay_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(219, 59);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(167, 34);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ :";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(6, 59);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(167, 34);
            this.dtpNgayBatDau.TabIndex = 0;
            this.dtpNgayBatDau.Value = new System.DateTime(2023, 4, 17, 23, 29, 42, 0);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(1297, 55);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(256, 45);
            this.txtTim.TabIndex = 10;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnGiaThapNhat
            // 
            this.btnGiaThapNhat.BackColor = System.Drawing.Color.White;
            this.btnGiaThapNhat.FlatAppearance.BorderSize = 0;
            this.btnGiaThapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaThapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnGiaThapNhat.Location = new System.Drawing.Point(549, 3);
            this.btnGiaThapNhat.Name = "btnGiaThapNhat";
            this.btnGiaThapNhat.Size = new System.Drawing.Size(176, 46);
            this.btnGiaThapNhat.TabIndex = 9;
            this.btnGiaThapNhat.Text = "Hóa đơn giá thấp nhất";
            this.btnGiaThapNhat.UseVisualStyleBackColor = false;
            this.btnGiaThapNhat.Click += new System.EventHandler(this.btnGiaThapNhat_Click);
            // 
            // btnGiaCaoNhat
            // 
            this.btnGiaCaoNhat.BackColor = System.Drawing.Color.White;
            this.btnGiaCaoNhat.FlatAppearance.BorderSize = 0;
            this.btnGiaCaoNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaCaoNhat.ForeColor = System.Drawing.Color.Black;
            this.btnGiaCaoNhat.Location = new System.Drawing.Point(367, 3);
            this.btnGiaCaoNhat.Name = "btnGiaCaoNhat";
            this.btnGiaCaoNhat.Size = new System.Drawing.Size(176, 46);
            this.btnGiaCaoNhat.TabIndex = 8;
            this.btnGiaCaoNhat.Text = "Hóa đơn giá cao nhất";
            this.btnGiaCaoNhat.UseVisualStyleBackColor = false;
            this.btnGiaCaoNhat.Click += new System.EventHandler(this.btnGiaCaoNhat_Click);
            // 
            // btnNgayCuNhat
            // 
            this.btnNgayCuNhat.BackColor = System.Drawing.Color.White;
            this.btnNgayCuNhat.FlatAppearance.BorderSize = 0;
            this.btnNgayCuNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayCuNhat.ForeColor = System.Drawing.Color.Black;
            this.btnNgayCuNhat.Location = new System.Drawing.Point(185, 3);
            this.btnNgayCuNhat.Name = "btnNgayCuNhat";
            this.btnNgayCuNhat.Size = new System.Drawing.Size(176, 46);
            this.btnNgayCuNhat.TabIndex = 7;
            this.btnNgayCuNhat.Text = "Hóa đơn cũ nhất";
            this.btnNgayCuNhat.UseVisualStyleBackColor = false;
            this.btnNgayCuNhat.Click += new System.EventHandler(this.btnNgayCuNhat_Click);
            // 
            // btnNgayMoiNhat
            // 
            this.btnNgayMoiNhat.BackColor = System.Drawing.Color.White;
            this.btnNgayMoiNhat.FlatAppearance.BorderSize = 0;
            this.btnNgayMoiNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgayMoiNhat.ForeColor = System.Drawing.Color.Black;
            this.btnNgayMoiNhat.Location = new System.Drawing.Point(3, 3);
            this.btnNgayMoiNhat.Name = "btnNgayMoiNhat";
            this.btnNgayMoiNhat.Size = new System.Drawing.Size(176, 46);
            this.btnNgayMoiNhat.TabIndex = 6;
            this.btnNgayMoiNhat.Text = "Hóa đơn mới nhất";
            this.btnNgayMoiNhat.UseVisualStyleBackColor = false;
            this.btnNgayMoiNhat.Click += new System.EventHandler(this.btnNgayMoiNhat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1293, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm kiếm theo từ khóa";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1565, 815);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpHoaDon);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnGiaThapNhat;
        private System.Windows.Forms.Button btnGiaCaoNhat;
        private System.Windows.Forms.Button btnNgayCuNhat;
        private System.Windows.Forms.Button btnNgayMoiNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Button btnLocNgay;
        private System.Windows.Forms.Button btnXeSDNhieu;
        private System.Windows.Forms.Button btnNhanVienDT;
        private System.Windows.Forms.Label label3;
    }
}