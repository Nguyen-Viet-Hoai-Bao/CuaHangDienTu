using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Connector_Tier
{
    public class ConnectorFactory
    {
        private string strConn = "Server = DESKTOP-QH9IM08\\HOAIBAO; Database = quanlychdientu; User Id = sa; pwd = 12345678; encrypt=false";
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private SqlConnection conn = null;

        //public SqlConnection Connection
        //{
          //  get { return conn; }
        //}
        public ConnectorFactory() { 
            conn = new SqlConnection(strConn);
        }

        public void openConnection()
        {
            try
            {
                if(conn.State == System.Data.ConnectionState.Closed) 
                {   
                    conn.Open();
                }
            }
            catch(Exception e) {
                throw e;
            }
        }
        public void closeConnection()
        {
            try
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }catch(Exception e) { throw e; }
        }
        public SqlDataReader getMember(string tableMember)
        {
            try
            {
                String query = "Select * from " + tableMember;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        } 
        public SqlDataReader getProduct(string tableProduct)
        {
            try
            {
                string query = "select * from " + tableProduct;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            
            return reader;
        }
        public void insertProduct(String name, int tonKho, int gia)
        {
            try
            {
                String query = "insert into sanpham ( productName , tonKho , gia) values ( @name, @tonKho , @gia)";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@tonKho", tonKho);
                cmd.Parameters.AddWithValue("@gia", gia);
                this.openConnection();
                cmd.ExecuteNonQuery ();
            }
            catch (Exception e) { throw e; }  
        }
        public void insertMember(String name, String diaChi, String viTri, int soDienThoai, String username, String password)
        {
            try
            {
                String query = "insert into member ( hoTen , diaChi, viTri, soDienThoai, username, password ) values ( @name, @diachi, @vitri, @soDienThoai, @username, @password)";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@vitri", viTri);
                cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        public void updateProduct(int id, String name, int tonkho, int gia)
        {
            try
            {
                String query = "Update sanpham set productName = @name, tonKho = @tonkho, gia = @gia where masp = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@tonkho", tonkho);
                cmd.Parameters.AddWithValue("@gia", gia);
                cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();

            }
            catch(Exception e) { throw e; }
        }
        public void updateMember(int id, String name, String diachi, String vitri, int phone, String username, String pwd)
        {
            try
            {
                String query = "Update member set hoTen = @name, diaChi = @diachi, viTri = @vitri, soDienThoai = @phone, username = @username, password = @pwd where menberID = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@diachi", diachi );
                cmd.Parameters.AddWithValue("@vitri", vitri);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@id", id);


                this.openConnection();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e) { throw e; }
        }
        public void deleteProduct(int id)
        {
            try
            {
                String query = "Delete from sanpham where masp = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch(Exception e) { throw e; }
        }
        public void deleteMember(int id)
        {
            try
            {
                String query = "Delete from member where menberID = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        public void deleteChiTietHoaDon(int id)
        {
            try
            {
                String query = "Delete from chitiethoadon where hoadonID = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }

        public void resetMemberID(int id)
        {
            try
            {
                String query = "DBCC CHECKIDENT (member, RESEED, "+id+")";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        public void resetProductID(int id)
        {
            try
            {
                String query = "DBCC CHECKIDENT (sanpham, RESEED, "+id+")";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        public void resetHoaDonID(int id)
        {
            try
            {
                String query = "DBCC CHECKIDENT (hoadon, RESEED, "+id+")";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                //cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        public SqlDataReader searchProduct(String name) 
        {
            //"select * from sanpham where tenSanPham LIKE '%" + name + "%' "
            try
            {
                String query = "select * from sanpham where productName LIKE '%"+name+"%'";
                cmd = new SqlCommand(query);   
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch(Exception e) { throw e; }
            return reader;
        }   
        public SqlDataReader searchMember(String name)
        {

            try
            {
                String query = "select * from member where hoTen LIKE '%"+name+"%'";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }

        // hoa don
        public SqlDataReader getHoaDon()
        {
            try
            {
                String query = "Select * from hoadon";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        public SqlDataReader getHoaDonFromID(int hoadonID)
        {
            try
            {
                String query = "Select * from hoadon where hoadonID = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", hoadonID);

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // get list chitiethoadon
        public SqlDataReader getListChiTietHoaDon(int hoadonID)
        {
            try
            {
                String query = "Select * from chitiethoadon where hoadonID = "+hoadonID;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // get hoadon
        public SqlDataReader getHoaDonNew()
        {
            try
            {
                String query = "Select * from hoadon where memberID = -1" ;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }

        // get member name
        public SqlDataReader getMemberName(int id)
        {
            try
            {
                String query = "Select hoTen from member where menberID = " + id;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // update hoadon
        public void updateHoaDon(int hoadonID, int memberID, int tongTien)
        {
            try
            {
                String query = "Update hoadon set memberID = @memberID, tongTien = @tongTien where hoadonID = @hoadonID";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@tongTien", tongTien);
                cmd.Parameters.AddWithValue("@hoadonID", hoadonID);



                this.openConnection();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e) { throw e; }
        }
        // get product name
        public SqlDataReader getProductName(int id)
        {
            try
            {
                String query = "Select productName from sanpham where masp = " + id;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // insert hoa don
        public void insertHoaDon(int memberID, int tongTien)
        {
            try
            {
                String query = "insert into hoadon (memberID, tongTien) values ( @memberID, @tongTien)";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@tongTien", tongTien);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        // insert New Hoa Don
        public void insertNewHoaDon(int memberID)
        {
            try
            {
                String query = "insert into hoadon (memberID, tongTien) values ( @memberID, @tongTien)";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@memberID", memberID);
                cmd.Parameters.AddWithValue("@tongTien", 0);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        //delete hoa don
        public void deleteHoaDon(int id)
        {
            try
            {
                String query = "Delete from hoadon where hoadonID = @id";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@id", id);

                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }
        // get Max hoadonID from hoadon
        public SqlDataReader getMaxHoaDonID()
        {
            try
            {
                String query = "SELECT MAX(hoadonID) FROM hoadon";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // get Max memberID
        public SqlDataReader getMaxMemberID()
        {
            try
            {
                String query = "SELECT MAX(menberID) FROM member";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // get Max memberID
        public SqlDataReader getMaxSanPhamID()
        {
            try
            {
                String query = "SELECT MAX(masp) FROM sanpham";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // get Min member ID from member
        public SqlDataReader getMinMemberID()
        {
            try
            {
                String query = "SELECT MIN(menberID) FROM member";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;

                this.openConnection();
                reader = cmd.ExecuteReader();
            }
            catch (Exception e) { throw e; }
            return reader;
        }
        // insert Chi tiet hoa don
        public void insertChiTietHoaDon(int hdID, int prdID, int soluong, int giaban)
        {
            try
            {
                String query = "insert into chitiethoadon (hoadonID, sanphamID, soluong, giaban) values ( @hoadonID, @sanphamID, @soluong, @giaban)";
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@hoadonID", hdID);
                cmd.Parameters.AddWithValue("@sanphamID", prdID);
                cmd.Parameters.AddWithValue("@soluong", soluong);
                cmd.Parameters.AddWithValue("@giaban", giaban);


                this.openConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) { throw e; }
        }

        public DataTable GetDataDangnhap(string sqlQuery)
        {
            DataTable dataTable = new DataTable();
            cmd = new SqlCommand();
            cmd.CommandText = sqlQuery;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = this.conn;
            try
            {
                this.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                string mex = e.Message;
                cmd.Dispose();
                this.closeConnection();
            }
            return dataTable;
        }
    }


}
