using Bus_Tier;
using CK_NET.ViewChiTietHoaDon;
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

namespace CK_NET.ViewHoaDon
{
    public partial class frmDanhSachHoaDon : Form
    {
        DataTable dataTable = null;
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataTable = new DataTable();
            BSHoaDon bSHoaDon = new BSHoaDon();
            BSMember bSMember = new BSMember();
            List<HoaDon> hoadons = bSHoaDon.getListHoaDon();
            dataTable.Columns.Add("ColumnIDHoaDon", typeof(int));
            dataTable.Columns.Add("ColumnIDMember", typeof(string));
            dataTable.Columns.Add("ColumnTongTien", typeof(int));
            foreach (HoaDon hoaDon in hoadons)
            {
                DataRow row = dataTable.NewRow();
                row["ColumnIDHoaDon"] = hoaDon.hoadonID;
                int id = hoaDon.memberID;
                row["ColumnIDMember"] = bSMember.getMemberName(id);
                row["ColumnTongTien"] = hoaDon.tongTien;
                dataTable.Rows.Add(row);
            }
            dtgvHoaDon.DataSource = dataTable;

            dtgvHoaDon.Refresh();
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
        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvHoaDon.Columns["ColumnButtonShow"].Index)
                {
                    var idHd = dtgvHoaDon.Rows[e.RowIndex].Cells["ColumnIDHoaDon"].Value.ToString();
                    var idMb = dtgvHoaDon.Rows[e.RowIndex].Cells["ColumnIDMember"].Value.ToString();
                    frmChiTiet f = new frmChiTiet(Int32.Parse(idHd), idMb);
                    AddForm(f);

                }
                if(e.ColumnIndex == dtgvHoaDon.Columns["ColumnButtonDelete"].Index)
                {
                    var idHd = dtgvHoaDon.Rows[e.RowIndex].Cells["ColumnIDHoaDon"].Value.ToString();
                    BSChiTietHoaDon bSChiTietHoaDon = new BSChiTietHoaDon();
                    bSChiTietHoaDon.deleteChiTietHoaDon(Int32.Parse(idHd));
                    BSHoaDon bSHoaDon = new BSHoaDon();
                    int max = bSHoaDon.getMaxHoaDonID();
                    bSHoaDon.deleteHoaDon(Int32.Parse(idHd));
                    if(max == Int32.Parse(idHd))
                    {
                        bSHoaDon.resetID(Int32.Parse(idHd) - 1);
                    }
                    load();
                }
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            BSMember bSMember = new BSMember();
            int minMemberID = bSMember.getMinMemberID();

            BSHoaDon bSHoaDon = new BSHoaDon();
            bSHoaDon.insertNewHoaDon(minMemberID);

            int maxHoaDonID = bSHoaDon.getMaxHoaDonID();


            frmChiTietHoaDon f = new frmChiTietHoaDon(maxHoaDonID);
            AddForm(f);
        }
    }
}
