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
    public class BSHoaDon
    {
        ConnectorFactory connHoaDon = null;

        public BSHoaDon()
        {
            connHoaDon= new ConnectorFactory();

        }
        public List<HoaDon> getListHoaDon()
        {
            SqlDataReader reader = null;
            List<HoaDon> listHoaDon = null;
            try
            {
                reader = connHoaDon.getHoaDon();
                listHoaDon = new List<HoaDon>();
                while (reader.Read())
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.hoadonID = reader.GetInt32(0);
                    hoaDon.memberID = reader.GetInt32(1);
                    hoaDon.tongTien = reader.GetInt32(2);

                    listHoaDon.Add(hoaDon);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
            return listHoaDon;

        }

        public void insertHoaDon(int memberId, int tongTien)
        {
            try
            {
                connHoaDon.insertHoaDon(memberId, tongTien);
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
        }

        public void insertNewHoaDon(int memberId)
        {
            try
            {
                connHoaDon.insertNewHoaDon(memberId);
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
        }
        public void deleteHoaDon(int hdID)
        {
            try
            {
                connHoaDon.deleteHoaDon(hdID);
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
        }
        public int getMaxHoaDonID()
        {
            SqlDataReader reader = null;
            int maxID=0;
            try
            {
                reader = connHoaDon.getMaxHoaDonID();
                while(reader.Read())
                {

                    maxID = reader.GetInt32(0);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
            return maxID;
        }

        public void updateHoaDon(int hoadonID, int memberID, int tongTien)
        {
            try
            {
                connHoaDon.updateHoaDon( hoadonID , memberID, tongTien);

            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
        }

        public void resetID(int id)
        {
            try
            {
                connHoaDon.resetHoaDonID(id);
            }
            catch (Exception ex) { throw ex; }
            finally { connHoaDon.closeConnection(); }
        }
    }
}
