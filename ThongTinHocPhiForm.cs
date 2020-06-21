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
    public partial class ThongTinHocPhiForm : Form
    {
        public ThongTinHocPhiForm()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=BT01DB;Integrated Security=SSPI;");

            SqlCommand sqlCmd = new SqlCommand(
                "SELECT S.MaSV, S.TenSV, SUM(M.SoTC) AS TongSoTC, SUM(M.SoTC) * 200000 AS HocPhi " +
                "FROM SinhVien S " +
                "JOIN DangKyMH D ON S.MaSV = D.MaSV " +
                "JOIN LopTC L ON L.MaLopTC = D.MaLopTC " +
                "JOIN MonHoc M ON M.MaMH = L.MaMH " +
                "GROUP BY S.MaSV, S.TenSV; ", conn);

            SqlDataAdapter adapt = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "HocPhi");
            dgvHocPhi.DataSource = ds.Tables["HocPhi"];
        }
    }
}
