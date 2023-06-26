using static System.Net.Mime.MediaTypeNames;

namespace QuanLyThueXeMay
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSetUpAPP = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAccount = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.btnManageAccount = new FontAwesome.Sharp.IconButton();
            this.btnInvoiceStatistics = new FontAwesome.Sharp.IconButton();
            this.btnContact = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.btnRentalActivity = new FontAwesome.Sharp.IconButton();
            this.btnVehicleInformation = new FontAwesome.Sharp.IconButton();
            this.btnUserInformation = new FontAwesome.Sharp.IconButton();
            this.panelUserInfor = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.ckSangToi = new System.Windows.Forms.CheckBox();
            this.btnCloseForm = new System.Windows.Forms.PictureBox();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelMenu.SuspendLayout();
            this.panelUserInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnSetUpAPP);
            this.panelMenu.Controls.Add(this.btnUpdateAccount);
            this.panelMenu.Controls.Add(this.iconButton8);
            this.panelMenu.Controls.Add(this.btnManageAccount);
            this.panelMenu.Controls.Add(this.btnInvoiceStatistics);
            this.panelMenu.Controls.Add(this.btnContact);
            this.panelMenu.Controls.Add(this.btnBill);
            this.panelMenu.Controls.Add(this.btnRentalActivity);
            this.panelMenu.Controls.Add(this.btnVehicleInformation);
            this.panelMenu.Controls.Add(this.btnUserInformation);
            this.panelMenu.Controls.Add(this.panelUserInfor);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(341, 972);
            this.panelMenu.TabIndex = 6;
            // 
            // btnSetUpAPP
            // 
            this.btnSetUpAPP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetUpAPP.FlatAppearance.BorderSize = 0;
            this.btnSetUpAPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUpAPP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUpAPP.ForeColor = System.Drawing.Color.White;
            this.btnSetUpAPP.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnSetUpAPP.IconColor = System.Drawing.Color.White;
            this.btnSetUpAPP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetUpAPP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetUpAPP.Location = new System.Drawing.Point(0, 774);
            this.btnSetUpAPP.Name = "btnSetUpAPP";
            this.btnSetUpAPP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSetUpAPP.Size = new System.Drawing.Size(341, 83);
            this.btnSetUpAPP.TabIndex = 17;
            this.btnSetUpAPP.Text = "Sao lưu dữ liệu";
            this.btnSetUpAPP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetUpAPP.UseVisualStyleBackColor = true;
            this.btnSetUpAPP.Click += new System.EventHandler(this.btnSetUpAPP_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccount.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnUpdateAccount.IconColor = System.Drawing.Color.White;
            this.btnUpdateAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAccount.Location = new System.Drawing.Point(0, 691);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUpdateAccount.Size = new System.Drawing.Size(341, 83);
            this.btnUpdateAccount.TabIndex = 16;
            this.btnUpdateAccount.Text = "Chỉnh thông tin tài khoản";
            this.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.Black;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton8.IconColor = System.Drawing.Color.Black;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(0, 889);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(341, 83);
            this.iconButton8.TabIndex = 15;
            this.iconButton8.Text = "Đăng xuất";
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.ForeColor = System.Drawing.Color.White;
            this.btnManageAccount.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnManageAccount.IconColor = System.Drawing.Color.White;
            this.btnManageAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 608);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnManageAccount.Size = new System.Drawing.Size(341, 83);
            this.btnManageAccount.TabIndex = 14;
            this.btnManageAccount.Text = "Quản lý tài khoản";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Visible = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnInvoiceStatistics
            // 
            this.btnInvoiceStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoiceStatistics.FlatAppearance.BorderSize = 0;
            this.btnInvoiceStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceStatistics.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoiceStatistics.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceStatistics.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTrendUp;
            this.btnInvoiceStatistics.IconColor = System.Drawing.Color.White;
            this.btnInvoiceStatistics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoiceStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoiceStatistics.Location = new System.Drawing.Point(0, 525);
            this.btnInvoiceStatistics.Name = "btnInvoiceStatistics";
            this.btnInvoiceStatistics.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInvoiceStatistics.Size = new System.Drawing.Size(341, 83);
            this.btnInvoiceStatistics.TabIndex = 13;
            this.btnInvoiceStatistics.Text = "Báo cáo thống kê";
            this.btnInvoiceStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoiceStatistics.UseVisualStyleBackColor = true;
            this.btnInvoiceStatistics.Visible = false;
            this.btnInvoiceStatistics.Click += new System.EventHandler(this.btnInvoiceStatistics_Click);
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.White;
            this.btnContact.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.btnContact.IconColor = System.Drawing.Color.White;
            this.btnContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContact.Location = new System.Drawing.Point(0, 442);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(341, 83);
            this.btnContact.TabIndex = 12;
            this.btnContact.Text = "Liên lạc";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnBill
            // 
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnBill.IconColor = System.Drawing.Color.White;
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBill.Location = new System.Drawing.Point(0, 359);
            this.btnBill.Name = "btnBill";
            this.btnBill.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBill.Size = new System.Drawing.Size(341, 83);
            this.btnBill.TabIndex = 11;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRentalActivity
            // 
            this.btnRentalActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentalActivity.FlatAppearance.BorderSize = 0;
            this.btnRentalActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalActivity.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalActivity.ForeColor = System.Drawing.Color.White;
            this.btnRentalActivity.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnRentalActivity.IconColor = System.Drawing.Color.White;
            this.btnRentalActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRentalActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRentalActivity.Location = new System.Drawing.Point(0, 276);
            this.btnRentalActivity.Name = "btnRentalActivity";
            this.btnRentalActivity.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRentalActivity.Size = new System.Drawing.Size(341, 83);
            this.btnRentalActivity.TabIndex = 10;
            this.btnRentalActivity.Text = "Hoạt động cho thuê";
            this.btnRentalActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentalActivity.UseVisualStyleBackColor = true;
            this.btnRentalActivity.Click += new System.EventHandler(this.btnRentalActivity_Click);
            // 
            // btnVehicleInformation
            // 
            this.btnVehicleInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicleInformation.FlatAppearance.BorderSize = 0;
            this.btnVehicleInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleInformation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleInformation.ForeColor = System.Drawing.Color.White;
            this.btnVehicleInformation.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.btnVehicleInformation.IconColor = System.Drawing.Color.White;
            this.btnVehicleInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVehicleInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicleInformation.Location = new System.Drawing.Point(0, 193);
            this.btnVehicleInformation.Name = "btnVehicleInformation";
            this.btnVehicleInformation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnVehicleInformation.Size = new System.Drawing.Size(341, 83);
            this.btnVehicleInformation.TabIndex = 9;
            this.btnVehicleInformation.Text = "Thông tin xe";
            this.btnVehicleInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleInformation.UseVisualStyleBackColor = true;
            this.btnVehicleInformation.Click += new System.EventHandler(this.btnVehicleInformation_Click);
            // 
            // btnUserInformation
            // 
            this.btnUserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInformation.FlatAppearance.BorderSize = 0;
            this.btnUserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInformation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInformation.ForeColor = System.Drawing.Color.White;
            this.btnUserInformation.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUserInformation.IconColor = System.Drawing.Color.White;
            this.btnUserInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserInformation.Location = new System.Drawing.Point(0, 110);
            this.btnUserInformation.Name = "btnUserInformation";
            this.btnUserInformation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUserInformation.Size = new System.Drawing.Size(341, 83);
            this.btnUserInformation.TabIndex = 8;
            this.btnUserInformation.Text = "Thông tin người dùng";
            this.btnUserInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserInformation.UseVisualStyleBackColor = true;
            this.btnUserInformation.Click += new System.EventHandler(this.btnUserInformation_Click);
            // 
            // panelUserInfor
            // 
            this.panelUserInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panelUserInfor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserInfor.Controls.Add(this.lbUsername);
            this.panelUserInfor.Controls.Add(this.label1);
            this.panelUserInfor.Controls.Add(this.imgUser);
            this.panelUserInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfor.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfor.Name = "panelUserInfor";
            this.panelUserInfor.Size = new System.Drawing.Size(341, 110);
            this.panelUserInfor.TabIndex = 7;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(164, 9);
            this.lbUsername.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(55, 19);
            this.lbUsername.TabIndex = 8;
            this.lbUsername.Text = "label2";
            this.lbUsername.Click += new System.EventHandler(this.lbUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên :";
            // 
            // imgUser
            // 
            this.imgUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgUser.Image = global::QuanLyThueXeMay.Properties.Resources.AvatarXanhNho1;
            this.imgUser.Location = new System.Drawing.Point(0, 0);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(106, 108);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 4;
            this.imgUser.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.ckSangToi);
            this.panelTitleBar.Controls.Add(this.btnCloseForm);
            this.panelTitleBar.Controls.Add(this.lbTitleBar);
            this.panelTitleBar.Controls.Add(this.btnHome);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(341, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1583, 100);
            this.panelTitleBar.TabIndex = 7;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // ckSangToi
            // 
            this.ckSangToi.AutoSize = true;
            this.ckSangToi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.ckSangToi.Location = new System.Drawing.Point(750, 24);
            this.ckSangToi.Name = "ckSangToi";
            this.ckSangToi.Size = new System.Drawing.Size(159, 36);
            this.ckSangToi.TabIndex = 13;
            this.ckSangToi.Text = "Chế độ tối";
            this.ckSangToi.UseVisualStyleBackColor = true;
            this.ckSangToi.CheckedChanged += new System.EventHandler(this.ckSangToi_CheckedChanged);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.Image = global::QuanLyThueXeMay.Properties.Resources.DauX1;
            this.btnCloseForm.Location = new System.Drawing.Point(1539, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(44, 100);
            this.btnCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCloseForm.TabIndex = 11;
            this.btnCloseForm.TabStop = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.AutoSize = true;
            this.lbTitleBar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBar.Location = new System.Drawing.Point(249, 28);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(84, 32);
            this.lbTitleBar.TabIndex = 10;
            this.lbTitleBar.Text = "Home";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(196, 100);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(341, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 10);
            this.panel1.TabIndex = 8;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(341, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1583, 862);
            this.panelDesktop.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QuanLyThueXeMay.Properties.Resources.MoToFlash;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1583, 862);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 972);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 950);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUserInfor.ResumeLayout(false);
            this.panelUserInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUserInfor;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnManageAccount;
        private FontAwesome.Sharp.IconButton btnInvoiceStatistics;
        private FontAwesome.Sharp.IconButton btnContact;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnRentalActivity;
        private FontAwesome.Sharp.IconButton btnVehicleInformation;
        private FontAwesome.Sharp.IconButton btnUserInformation;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnUpdateAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCloseForm;
        private FontAwesome.Sharp.IconButton btnSetUpAPP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox ckSangToi;
    }
}