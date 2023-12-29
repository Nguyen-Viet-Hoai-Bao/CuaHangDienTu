using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Tier
{
    public class BSTaiKhoan
    {
        ConnectorFactory connTaiKhoan = null;
        public BSTaiKhoan()
        {
            connTaiKhoan = new ConnectorFactory();
        }
        public List<Product> getListProduct()
        {
            SqlDataReader reader = null;
            List<Product> listProduct = null;
            try
            {
                reader = connTaiKhoan.getProduct("sanpham");
                listProduct = new List<Product>();
                while (reader.Read())
                {
                    Product product = new Product();
                    product.productID = reader.GetInt32(0);
                    product.productName = reader.GetString(1);
                    product.tonKho = reader.GetInt32(2);
                    product.giaBan = reader.GetInt32(3);
                    listProduct.Add(product);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connTaiKhoan.closeConnection(); }
            return listProduct;

        }
    }
}
