using Bus_Tier;
using CK_NET.ViewHoaDon;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_NET.ViewChiTietHoaDon
{
    public partial class frmChiTiet : Form
    {
        DataTable dataTable = null;
        private int idHoaDon;
        private String idMember;
        public frmChiTiet(int idHd, String idMb)
        {
            this.idHoaDon = idHd;
            this.idMember = idMb;
            InitializeComponent();
        }
        public void load()
        {

            dataTable = new DataTable();
            BSChiTietHoaDon bSChiTietHoaDon = new BSChiTietHoaDon();

            lbID.Text = idHoaDon.ToString();
            lbMember.Text = idMember;

            List<ChiTietHoaDon> cthds = bSChiTietHoaDon.getListChiTietHoaDon(this.idHoaDon);

            dataTable.Columns.Add("ColumnProduct", typeof(string));
            dataTable.Columns.Add("ColumnSoLuong", typeof(int));
            dataTable.Columns.Add("ColumnGia", typeof(int));
            foreach (ChiTietHoaDon hoaDon in cthds)
            {
                DataRow row = dataTable.NewRow(); 
                BSProduct bSProduct = new BSProduct();
                row["ColumnProduct"] = bSProduct.getProductName(hoaDon.sanphamID);
                row["ColumnSoLuong"] = hoaDon.soluong;
                row["ColumnGia"] = hoaDon.giaban;
                dataTable.Rows.Add(row);
            }
            dtgvChiTietHoaDon.DataSource= dataTable;

            dtgvChiTietHoaDon.Refresh();
        }
        private void AddForm(Form f)
        {
            this.Controls.Remove(panel1);
            this.Controls.Remove(panel2);
            this.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.Show();
        }
        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmDanhSachHoaDon f = new frmDanhSachHoaDon();
            AddForm(f);
        }
    }
}
