namespace QuanLyThueXeMay.FormService
{
    partial class frmLienLac
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpTinNhan = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTuNguoiDung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungGui = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "liên lạc";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.flpTinNhan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1493, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tin nhắn đến";
            // 
            // flpTinNhan
            // 
            this.flpTinNhan.AutoScroll = true;
            this.flpTinNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTinNhan.Location = new System.Drawing.Point(3, 26);
            this.flpTinNhan.Name = "flpTinNhan";
            this.flpTinNhan.Size = new System.Drawing.Size(1487, 450);
            this.flpTinNhan.TabIndex = 0;
            // 
            // cbTuNguoiDung
            // 
            this.cbTuNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTuNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.cbTuNguoiDung.FormattingEnabled = true;
            this.cbTuNguoiDung.Location = new System.Drawing.Point(1216, 35);
            this.cbTuNguoiDung.Name = "cbTuNguoiDung";
            this.cbTuNguoiDung.Size = new System.Drawing.Size(318, 33);
            this.cbTuNguoiDung.TabIndex = 1;
            this.cbTuNguoiDung.SelectedIndexChanged += new System.EventHandler(this.cbTuNguoiDung_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1211, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tin nhắn từ :";
            // 
            // txtNoiDungGui
            // 
            this.txtNoiDungGui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoiDungGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungGui.Location = new System.Drawing.Point(44, 644);
            this.txtNoiDungGui.Name = "txtNoiDungGui";
            this.txtNoiDungGui.Size = new System.Drawing.Size(1490, 200);
            this.txtNoiDungGui.TabIndex = 3;
            this.txtNoiDungGui.Text = "";
            this.txtNoiDungGui.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoiDungGui_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(39, 616);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Gửi tin nhắn";
            // 
            // frmLienLac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1565, 815);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoiDungGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTuNguoiDung);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLienLac";
            this.Text = "frmLienLac";
            this.Load += new System.EventHandler(this.frmLienLac_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpTinNhan;
        private System.Windows.Forms.ComboBox cbTuNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNoiDungGui;
        private System.Windows.Forms.Label label9;
    }
}