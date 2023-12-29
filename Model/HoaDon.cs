using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HoaDon
    {
        public int hoadonID { get; set; }
        public int memberID { get; set; }
        public int tongTien { get; set; }

        public override string ToString()
        {
            return hoadonID.ToString()+", "+memberID.ToString()+", "+tongTien.ToString();
        }

    }
}
