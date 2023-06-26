namespace QuanLyThueXeMay.FormService
{
    partial class VehicleShowStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.icPicXe = new FontAwesome.Sharp.IconPictureBox();
            this.lbTenXe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icPicXe)).BeginInit();
            this.SuspendLayout();
            // 
            // icPicXe
            // 
            this.icPicXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.icPicXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icPicXe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icPicXe.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.icPicXe.IconColor = System.Drawing.SystemColors.ControlText;
            this.icPicXe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icPicXe.IconSize = 140;
            this.icPicXe.Location = new System.Drawing.Point(0, 0);
            this.icPicXe.Margin = new System.Windows.Forms.Padding(10);
            this.icPicXe.Name = "icPicXe";
            this.icPicXe.Size = new System.Drawing.Size(160, 140);
            this.icPicXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.icPicXe.TabIndex = 0;
            this.icPicXe.TabStop = false;
            this.icPicXe.Click += new System.EventHandler(this.icPicXe_Click);
            // 
            // lbTenXe
            // 
            this.lbTenXe.AutoSize = true;
            this.lbTenXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbTenXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenXe.Location = new System.Drawing.Point(0, 120);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(59, 20);
            this.lbTenXe.TabIndex = 1;
            this.lbTenXe.Text = "label1";
            // 
            // VehicleShowStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTenXe);
            this.Controls.Add(this.icPicXe);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "VehicleShowStatus";
            this.Size = new System.Drawing.Size(160, 140);
            this.Load += new System.EventHandler(this.VehicleShowStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icPicXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icPicXe;
        private System.Windows.Forms.Label lbTenXe;
    }
}
