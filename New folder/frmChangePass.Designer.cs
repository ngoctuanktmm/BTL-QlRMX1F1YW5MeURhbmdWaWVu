namespace BTL_QuanLyDangVien
{
    partial class frmChangePass
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.btnNhaplai = new System.Windows.Forms.Button();
            this.btnThaydoi = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập lại:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(153, 67);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 25);
            this.txtPassword.TabIndex = 5;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewPass.Location = new System.Drawing.Point(153, 109);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(185, 25);
            this.txtNewPass.TabIndex = 6;
            // 
            // txtRePass
            // 
            this.txtRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtRePass.Location = new System.Drawing.Point(153, 151);
            this.txtRePass.Multiline = true;
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.PasswordChar = '*';
            this.txtRePass.Size = new System.Drawing.Size(185, 25);
            this.txtRePass.TabIndex = 7;
            // 
            // btnNhaplai
            // 
            this.btnNhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhaplai.ForeColor = System.Drawing.Color.Blue;
            this.btnNhaplai.Location = new System.Drawing.Point(153, 209);
            this.btnNhaplai.Name = "btnNhaplai";
            this.btnNhaplai.Size = new System.Drawing.Size(80, 29);
            this.btnNhaplai.TabIndex = 8;
            this.btnNhaplai.Text = "Nhập lại";
            this.btnNhaplai.UseVisualStyleBackColor = true;
            // 
            // btnThaydoi
            // 
            this.btnThaydoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThaydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThaydoi.ForeColor = System.Drawing.Color.Blue;
            this.btnThaydoi.Location = new System.Drawing.Point(24, 209);
            this.btnThaydoi.Name = "btnThaydoi";
            this.btnThaydoi.Size = new System.Drawing.Size(80, 29);
            this.btnThaydoi.TabIndex = 9;
            this.btnThaydoi.Text = "Thay đổi";
            this.btnThaydoi.UseVisualStyleBackColor = true;
            this.btnThaydoi.Click += new System.EventHandler(this.btnThaydoi_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Blue;
            this.btnBack.Location = new System.Drawing.Point(269, 209);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 29);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnThaydoi);
            this.Controls.Add(this.btnNhaplai);
            this.Controls.Add(this.txtRePass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmChangePass";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.Button btnNhaplai;
        private System.Windows.Forms.Button btnThaydoi;
        private System.Windows.Forms.Button btnBack;
    }
}