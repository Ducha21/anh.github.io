namespace D13CNPM3_TH01
{
    partial class SinhVienForm
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblThongTinSinhVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 61);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(776, 377);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // lblThongTinSinhVien
            // 
            this.lblThongTinSinhVien.AutoSize = true;
            this.lblThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinSinhVien.Location = new System.Drawing.Point(13, 19);
            this.lblThongTinSinhVien.Name = "lblThongTinSinhVien";
            this.lblThongTinSinhVien.Size = new System.Drawing.Size(240, 29);
            this.lblThongTinSinhVien.TabIndex = 1;
            this.lblThongTinSinhVien.Text = "Thông tin sinh viên:";
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongTinSinhVien);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "SinhVienForm";
            this.Text = "Thông sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblThongTinSinhVien;
    }
}