namespace QuanLyThueXeMay.FormService
{
    partial class frmSetUpApplication
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
            this.btnSaoluu = new System.Windows.Forms.Button();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaoluu
            // 
            this.btnSaoluu.ForeColor = System.Drawing.Color.Black;
            this.btnSaoluu.Location = new System.Drawing.Point(168, 196);
            this.btnSaoluu.Name = "btnSaoluu";
            this.btnSaoluu.Size = new System.Drawing.Size(305, 95);
            this.btnSaoluu.TabIndex = 0;
            this.btnSaoluu.Text = "Sao lưu dữu liệu";
            this.btnSaoluu.UseVisualStyleBackColor = true;
            this.btnSaoluu.Click += new System.EventHandler(this.btnSaoluu_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.ForeColor = System.Drawing.Color.Black;
            this.btnPhucHoi.Location = new System.Drawing.Point(1160, 196);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(299, 95);
            this.btnPhucHoi.TabIndex = 1;
            this.btnPhucHoi.Text = "Phục hồi dữ liệu";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // frmSetUpApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1565, 815);
            this.Controls.Add(this.btnPhucHoi);
            this.Controls.Add(this.btnSaoluu);
            this.Name = "frmSetUpApplication";
            this.Text = "frmSetUpApplication";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaoluu;
        private System.Windows.Forms.Button btnPhucHoi;
    }
}