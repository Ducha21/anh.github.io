namespace D13CNPM3_TH01
{
    partial class ThongTinHocPhiForm
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
            this.dgvHocPhi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông tin học phí";
            // 
            // dgvHocPhi
            // 
            this.dgvHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhi.Location = new System.Drawing.Point(44, 76);
            this.dgvHocPhi.Name = "dgvHocPhi";
            this.dgvHocPhi.RowTemplate.Height = 24;
            this.dgvHocPhi.Size = new System.Drawing.Size(713, 332);
            this.dgvHocPhi.TabIndex = 3;
            // 
            // ThongTinHocPhiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocPhi);
            this.Name = "ThongTinHocPhiForm";
            this.Text = "ThongTinHocPhiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocPhi;
    }
}