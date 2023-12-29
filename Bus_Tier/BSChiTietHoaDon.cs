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
    public class BSChiTietHoaDon
    {
        ConnectorFactory connChiTietHoaDon = null;

        public BSChiTietHoaDon() { 
            connChiTietHoaDon = new ConnectorFactory();
        }
        public List<ChiTietHoaDon> getListChiTietHoaDon(int id)
        {
            SqlDataReader reader = null;
            List<ChiTietHoaDon> listChiTietHoaDon = null;
            try
            {
                reader = connChiTietHoaDon.getListChiTietHoaDon(id);
                listChiTietHoaDon = new List<ChiTietHoaDon>();
                while (reader.Read())
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon();
                    cthd.hoadonID = reader.GetInt32(0);
                    cthd.sanphamID= reader.GetInt32(1);
                    cthd.soluong = reader.GetInt32(2);
                    cthd.giaban= reader.GetInt32(3);
                    listChiTietHoaDon.Add(cthd);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { connChiTietHoaDon.closeConnection(); }
            return listChiTietHoaDon;

        }

        public void insertChiTietHoaDon(ChiTietHoaDon cthd)
        {
            try
            {
                connChiTietHoaDon.insertChiTietHoaDon(cthd.hoadonID, cthd.sanphamID, cthd.soluong, cthd.giaban);
            }
            catch (Exception ex) { throw ex; }
            finally { connChiTietHoaDon.closeConnection(); }
        }

        public void deleteChiTietHoaDon(int hdID)
        {
            try
            {
                connChiTietHoaDon.deleteChiTietHoaDon(hdID);
            }
            catch (Exception ex) { throw ex; }
            finally { connChiTietHoaDon.closeConnection(); }
        }

    }
}
