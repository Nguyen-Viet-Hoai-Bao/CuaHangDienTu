using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ChiTietHoaDon
    {
        public int hoadonID { get; set; }
        public int sanphamID { get; set; }
        public int soluong { get; set; }
        public int giaban { get; set; }

        public override string ToString()
        {
            return hoadonID.ToString()+", "+sanphamID.ToString()+", "+soluong.ToString()+", "+giaban.ToString();
        }
    }
}
