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
    public partial class SinhVienForm : Form
    {
        public SinhVienForm()
        {
            InitializeComponent();

            /////Load dữ liệu sinh viên
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=BT01DB;Integrated Security=SSPI;");

            SqlCommand sqlCmd = new SqlCommand(
                "SELECT * FROM SinhVien ORDER BY TenSV ASC", conn);

            SqlDataAdapter adapt = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "SV");
            dgvSinhVien.DataSource = ds.Tables["SV"];
        }
    }
}
