using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member
    {
        public int memberID { get; set; }
        public String hoTen { get; set; }
        public String diaChi { get; set; }
        public String viTri { get; set; }
        public int soDienThoai { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public override string ToString()
        {
            return memberID.ToString() + "; " + hoTen + "; " + diaChi + "; " + viTri + "; " + soDienThoai.ToString() + "; " + username + "; " + password;
        }
    }
}
