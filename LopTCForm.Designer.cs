namespace D13CNPM3_TH01
{
    partial class LopTCForm
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLopTC = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbNamHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHocKy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSoTinChi = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.tbMaLopTC = new System.Windows.Forms.TextBox();
            this.lblMaLopTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTC)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(251, 272);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(255, 22);
            this.tbSearch.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tìm kiếm theo môn học:";
            // 
            // dgvLopTC
            // 
            this.dgvLopTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopTC.Location = new System.Drawing.Point(99, 323);
            this.dgvLopTC.Name = "dgvLopTC";
            this.dgvLopTC.RowTemplate.Height = 24;
            this.dgvLopTC.Size = new System.Drawing.Size(839, 325);
            this.dgvLopTC.TabIndex = 31;
            this.dgvLopTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopTC_CellClick);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(584, 266);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(86, 34);
            this.btSearch.TabIndex = 30;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(584, 148);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(86, 34);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(584, 92);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(86, 34);
            this.btEdit.TabIndex = 28;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(584, 40);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(86, 34);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbNamHoc
            // 
            this.tbNamHoc.Location = new System.Drawing.Point(251, 209);
            this.tbNamHoc.Name = "tbNamHoc";
            this.tbNamHoc.Size = new System.Drawing.Size(255, 22);
            this.tbNamHoc.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Năm học:";
            // 
            // tbHocKy
            // 
            this.tbHocKy.Location = new System.Drawing.Point(251, 165);
            this.tbHocKy.Name = "tbHocKy";
            this.tbHocKy.Size = new System.Drawing.Size(255, 22);
            this.tbHocKy.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Học kỳ:";
            // 
            // tbSoTinChi
            // 
            this.tbSoTinChi.Enabled = false;
            this.tbSoTinChi.Location = new System.Drawing.Point(251, 122);
            this.tbSoTinChi.Name = "tbSoTinChi";
            this.tbSoTinChi.Size = new System.Drawing.Size(255, 22);
            this.tbSoTinChi.TabIndex = 22;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(128, 122);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(70, 17);
            this.lblSoTinChi.TabIndex = 21;
            this.lblSoTinChi.Text = "Số tín chỉ:";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(251, 72);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(255, 24);
            this.cbbMonHoc.TabIndex = 20;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged);
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(131, 72);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(66, 17);
            this.lblMonHoc.TabIndex = 19;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // tbMaLopTC
            // 
            this.tbMaLopTC.Location = new System.Drawing.Point(251, 28);
            this.tbMaLopTC.Name = "tbMaLopTC";
            this.tbMaLopTC.Size = new System.Drawing.Size(255, 22);
            this.tbMaLopTC.TabIndex = 18;
            // 
            // lblMaLopTC
            // 
            this.lblMaLopTC.AutoSize = true;
            this.lblMaLopTC.Location = new System.Drawing.Point(128, 28);
            this.lblMaLopTC.Name = "lblMaLopTC";
            this.lblMaLopTC.Size = new System.Drawing.Size(95, 17);
            this.lblMaLopTC.TabIndex = 17;
            this.lblMaLopTC.Text = "Mã lớp tín chỉ:";
            // 
            // LopTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 677);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLopTC);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbNamHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHocKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoTinChi);
            this.Controls.Add(this.lblSoTinChi);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.tbMaLopTC);
            this.Controls.Add(this.lblMaLopTC);
            this.Name = "LopTCForm";
            this.Text = "Quản lý lớp tín chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLopTC;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbNamHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHocKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSoTinChi;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.TextBox tbMaLopTC;
        private System.Windows.Forms.Label lblMaLopTC;
    }
}