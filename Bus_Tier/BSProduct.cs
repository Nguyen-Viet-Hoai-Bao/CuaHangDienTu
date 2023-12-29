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
    public class BSProduct
    {
        ConnectorFactory connProduct = null;
        public BSProduct()
        {
            connProduct = new ConnectorFactory();
        }
        public List<Product> getListProduct()
        {
            SqlDataReader reader = null;
            List<Product> listProduct = null;
            try
            {
                reader = connProduct.getProduct("sanpham");
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
            catch(Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
            return listProduct;

        }
        public void insert(Product product)
        {
            try
            {
                connProduct.insertProduct(product.productName, product.tonKho, product.giaBan);
            }
            catch (Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
        }

        public void updateProduct(Product product) 
        {
            try
            {
                connProduct.updateProduct(product.productID, product.productName, product.tonKho, product.giaBan);

            }catch(Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
        }
        public int deleteProduct(int id)
        {
            try
            {
                connProduct.deleteProduct(id);
                return 1;
            }catch(Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
        }
        public List<Product> searchProduct(String name)
        {

            SqlDataReader reader = null;
            List<Product> listProduct = null;
            try
            {
                reader = connProduct.searchProduct(name);
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
            catch(Exception ex) { throw ex; }
            finally
            {
                connProduct.closeConnection();
            }
            return listProduct;
        }
        public String getProductName(int id)
        {
            SqlDataReader reader = null;
            String name = null;
            try
            {
                reader = connProduct.getProductName(id);
                while (reader.Read())
                {
                    name = reader.GetString(0);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
            return name;
        }
        public int getMaxProductID()
        {
            SqlDataReader reader = null;
            int maxID = 0;
            try
            {
                reader = connProduct.getMaxSanPhamID();
                while (reader.Read())
                {

                    maxID = reader.GetInt32(0);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
            return maxID;
        }

        public void resetID(int id)
        {
            try
            {
                connProduct.resetProductID(id);
            }
            catch (Exception ex) { throw ex; }
            finally { connProduct.closeConnection(); }
        }
    }
}
