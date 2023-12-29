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
    public partial class frmChiTietHoaDon : Form
    {
        int HoaDonID;
        private int tongtien = 0;
        private int stt = 0;

        public List<ChiTietHoaDon> cthds = new List<ChiTietHoaDon>();
        DataTable dataTable;
        public frmChiTietHoaDon(int hoaDonID)
        {
            InitializeComponent();
            HoaDonID = hoaDonID;
        }

        public void load()
        {
            BSMember bSMember = new BSMember();
            List<Member> members = bSMember.getListMember();
            comboBox4.DataSource = members;
            comboBox4.DisplayMember = "menberID";
            comboBox4.ValueMember = "hoTen";

            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.getListProduct();
            comboBox2.DataSource = products;
            comboBox2.DisplayMember = "masp";
            comboBox2.ValueMember = "productName";

            BSChiTietHoaDon bSChiTietHoaDon = new BSChiTietHoaDon();

            dataTable = new DataTable();
            dataTable.Columns.Add("ColumnSTT", typeof(int));
            dataTable.Columns.Add("ColumnProductName", typeof(String));
            dataTable.Columns.Add("ColumnSoLuong", typeof(int));
            dataTable.Columns.Add("ColumnGiaBan", typeof(int));
            dataTable.Clear();
            stt = 0;
            foreach(ChiTietHoaDon cthd in cthds)
            {
                stt++;
                DataRow row = dataTable.NewRow();
                row["ColumnSTT"] = stt;
                row["ColumnProductName"] = products[cthd.sanphamID].productName;
                row["ColumnSoLuong"] = cthd.soluong;
                row["ColumnGiaBan"] = cthd.giaban;

                dataTable.Rows.Add(row);
            }
            dtgvChiTietHoaDon.DataSource = dataTable;
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
        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = comboBox2.Text;
            int soluong = Int32.Parse(txtSoLuong.Text);
            Product product = (Product)comboBox2.SelectedItem;
            int giaban = product.giaBan;
            int prdID = product.productID;

            ChiTietHoaDon cthd = new ChiTietHoaDon();
            cthd.hoadonID = HoaDonID;
            cthd.sanphamID = prdID;
            cthd.soluong = Int32.Parse(txtSoLuong.Text);
            cthd.giaban = giaban;

            this.cthds.Add(cthd);

            tongtien += soluong * giaban;
            txtTongTien.Text = tongtien.ToString();

            BSChiTietHoaDon bSChiTietHoaDon = new BSChiTietHoaDon();
            bSChiTietHoaDon.insertChiTietHoaDon(cthd);
            
            load();
        }

        private void dtgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvChiTietHoaDon.Columns["ColumnDelete"].Index)
                {
                    int stt = Int32.Parse(dtgvChiTietHoaDon.Rows[e.RowIndex].Cells["ColumnSTT"].Value.ToString());
                    tongtien -= cthds[stt-1].giaban*cthds[stt-1].soluong;
                    cthds.RemoveAt(stt-1);
                    txtTongTien.Text = tongtien.ToString();
                    MessageBox.Show(tongtien.ToString());
                }
                load();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BSHoaDon bSHoaDon = new BSHoaDon();

                Member member = (Member)comboBox4.SelectedItem;
                bSHoaDon.updateHoaDon( HoaDonID ,member.memberID, tongtien);


                MessageBox.Show("thanh cong");
                frmDanhSachHoaDon f = new frmDanhSachHoaDon();
                AddForm(f);

            }catch(Exception ex) { throw ex; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tongtien == 0)
            {
                BSHoaDon bSHoaDon = new BSHoaDon();
                bSHoaDon.deleteHoaDon( HoaDonID );
            }
            frmDanhSachHoaDon f = new frmDanhSachHoaDon();
            AddForm(f);
        }
    }
}
