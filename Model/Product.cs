using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public int tonKho{ get; set; }
        public int giaBan { get; set; }

        public override string ToString()
        {
            return productID.ToString()+"; "+productName+"; "+tonKho.ToString()+"; "+giaBan.ToString();
        }
    }
}
