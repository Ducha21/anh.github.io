using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D13CNPM3_TH01
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KQA75V7\SQLEXPRESS;Initial Catalog=SinhVien;Integrated Security=True");

            SqlCommand sqlCmd = new SqlCommand(
                "SELECT * FROM NguoiDung WHERE TaiKhoan=@taiKhoan AND MatKhau=@matKhau", conn);

            sqlCmd.Parameters.AddWithValue("@taiKhoan", tbUserName.Text);
            sqlCmd.Parameters.AddWithValue("@matKhau", tbPassword.Text);

            conn.Open();

            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.Read())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc Mật khẩu không đúng!");
            }

            conn.Close();

            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
