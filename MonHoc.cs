using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D13CNPM3_TH01
{
    public class MonHoc
    {
        public string MaMonHoc { get; }

        public string TenMonHoc { get; }

        public int SoTinChi { get; }

        public MonHoc(string maMonHoc, string tenMonHoc, int soTinChi)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
            SoTinChi = soTinChi;
        }
    }
}
