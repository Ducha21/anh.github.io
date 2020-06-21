namespace D13CNPM3_TH01
{
    partial class LogInForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(55, 51);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(112, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên người dùng:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(192, 51);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(230, 22);
            this.tbUserName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(192, 104);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(230, 22);
            this.tbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 104);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(192, 159);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(96, 38);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(326, 159);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 38);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 230);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "LogInForm";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
    }
}