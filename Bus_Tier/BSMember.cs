using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Tier
{
    public class BSMember
    {
        ConnectorFactory connMember = null;

        public BSMember()
        {
            connMember = new ConnectorFactory();
        }

        public List<Member> getListMember()
        {
            SqlDataReader reader = null;
            List<Member> listMember = null;

            try
            {
                reader = connMember.getMember("member");
                listMember = new List<Member>();
                while (reader.Read())
                {
                    Member member = new Member();
                    member.memberID = reader.GetInt32(0);
                    member.hoTen = reader.GetString(1);
                    member.diaChi = reader.GetString(2);
                    member.viTri = reader.GetString(3);
                    member.soDienThoai = reader.GetInt32(4);
                    member.username = reader.GetString(5);
                    member.password = reader.GetString(6);
                    listMember.Add(member);
                }
            }
            catch (Exception e) { throw e; }
            finally { connMember.closeConnection(); }

            return listMember;
        }
        public void insert(Member member)
        {
            try
            {
                connMember.insertMember(member.hoTen, member.diaChi, member.viTri, member.soDienThoai, member.username, member.password);
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
        }
        public void updateMember(Member member)
        {
            try
            {
                connMember.updateMember(member.memberID, member.hoTen, member.diaChi, member.viTri, member.soDienThoai, member.username, member.password);

            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
        }
        public int deleteMember(int id)
        {
            try
            {
                connMember.deleteMember(id);
                return 1;
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
        }
        public List<Member> searchMember(String name)
        {

            SqlDataReader reader = null;
            List<Member> listMember = null;
            try
            {
                reader = connMember.searchMember(name);
                listMember = new List<Member>();
                while (reader.Read())
                {
                    Member member = new Member();
                    member.memberID = reader.GetInt32(0);
                    member.hoTen = reader.GetString(1);
                    member.diaChi = reader.GetString(2);
                    member.viTri = reader.GetString(3);
                    member.soDienThoai = reader.GetInt32(4);
                    member.username = reader.GetString(5);
                    member.password = reader.GetString(6);
                    listMember.Add(member);
                }
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                connMember.closeConnection();
            }
            return listMember;
        }
        public String getMemberName(int id)
        {
            SqlDataReader reader = null;
            String name = null;
            try
            {
                reader = connMember.getMemberName(id);
                while (reader.Read())
                {
                    name = reader.GetString(0);
                    
                } 
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
            return name;
        }

        public DataTable GetData(String sql)
        {
            DataTable dataTable = new DataTable();
            ConnectorFactory conn = new ConnectorFactory();
            dataTable = conn.GetDataDangnhap(sql);
            return dataTable;
        }
        public int getMinMemberID()
        {
            SqlDataReader reader = null;
            int minID = 0;
            try
            {
                reader = connMember.getMinMemberID();
                while (reader.Read())
                {

                    minID = reader.GetInt32(0);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
            return minID;
        }
        public int getMaxMemberID()
        {
            SqlDataReader reader = null;
            int maxID = 0;
            try
            {
                reader = connMember.getMaxMemberID();
                while (reader.Read())
                {

                    maxID = reader.GetInt32(0);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
            return maxID;
        }

        public void resetID(int id)
        {
            try
            {
                connMember.resetMemberID(id);
            }
            catch (Exception ex) { throw ex; }
            finally { connMember.closeConnection(); }
        }
    }
}
