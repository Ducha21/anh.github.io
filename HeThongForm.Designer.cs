namespace D13CNPM3_TH01
{
    partial class HeThongForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpTínChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngHợpHọcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.lớpTínChỉToolStripMenuItem,
            this.tổngHợpHọcPhíToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.sinhViênToolStripMenuItem.Text = "&Sinh viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // lớpTínChỉToolStripMenuItem
            // 
            this.lớpTínChỉToolStripMenuItem.Name = "lớpTínChỉToolStripMenuItem";
            this.lớpTínChỉToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.lớpTínChỉToolStripMenuItem.Text = "&Lớp tín chỉ";
            this.lớpTínChỉToolStripMenuItem.Click += new System.EventHandler(this.lớpTínChỉToolStripMenuItem_Click);
            // 
            // tổngHợpHọcPhíToolStripMenuItem
            // 
            this.tổngHợpHọcPhíToolStripMenuItem.Name = "tổngHợpHọcPhíToolStripMenuItem";
            this.tổngHợpHọcPhíToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.tổngHợpHọcPhíToolStripMenuItem.Text = "&Tổng hợp học phí";
            this.tổngHợpHọcPhíToolStripMenuItem.Click += new System.EventHandler(this.tổngHợpHọcPhíToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.logoutToolStripMenuItem.Text = "L&ogout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // HeThongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HeThongForm";
            this.Text = "Hệ thống Quản lý đăng kí môn học";
            this.Load += new System.EventHandler(this.HeThongForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpTínChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngHợpHọcPhíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

