using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D13CNPM3_TH01
{
    public partial class HeThongForm : Form
    {
        public HeThongForm()
        {
            InitializeComponent();
        }

        private void HeThongForm_Load(object sender, EventArgs e)
        {
            LogInForm loginForm = new LogInForm();
            DialogResult result = loginForm.ShowDialog();
            if (result != DialogResult.OK)
            {
                this.Close();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogInForm loginForm = new LogInForm();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVienForm sinhVienForm = new SinhVienForm();
            sinhVienForm.ShowDialog();
        }

        private void lớpTínChỉToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopTCForm lopTCForm = new LopTCForm();
            lopTCForm.ShowDialog();
        }

        private void tổngHợpHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinHocPhiForm thongTinHocPhiForm = new ThongTinHocPhiForm();
            thongTinHocPhiForm.ShowDialog();
        }
    }
}
