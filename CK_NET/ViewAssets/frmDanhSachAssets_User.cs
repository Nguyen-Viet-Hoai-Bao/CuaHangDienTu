using Bus_Tier;
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

namespace CK_NET.ViewAssets
{
    public partial class frmDanhSachAssets_User : Form
    {
        DataTable dataTable = null;
        public frmDanhSachAssets_User()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataTable = new DataTable();
            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.getListProduct();
            dataTable.Columns.Add("ColumnId", typeof(int));
            dataTable.Columns.Add("ColumnName", typeof(string));
            dataTable.Columns.Add("ColumnTonKho", typeof(int));
            dataTable.Columns.Add("ColumnGiaBan", typeof(int));
            foreach (Product product in products)
            {
                DataRow row = dataTable.NewRow();
                row["ColumnID"] = product.productID;
                row["ColumnName"] = product.productName;
                row["ColumnTonKho"] = product.tonKho;
                row["ColumnGiaBan"] = product.giaBan;
                dataTable.Rows.Add(row);
            }
            dtgvAssets.DataSource = dataTable;

            dtgvAssets.Refresh();
        }
        private void frmDanhSachAssets_User_Load(object sender, EventArgs e)
        {
            load();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Trangchu))
                {
                    form.Close();
                }
            }
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void dtgvAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String name = txtTukhoa.Text;
            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.searchProduct(name);
            dataTable = new DataTable();
            dataTable.Columns.Add("ColumnId", typeof(int));
            dataTable.Columns.Add("ColumnName", typeof(string));
            dataTable.Columns.Add("ColumnTonKho", typeof(int));
            dataTable.Columns.Add("ColumnGiaBan", typeof(int));
            foreach (Product product in products)
            {
                DataRow row = dataTable.NewRow();
                row["ColumnID"] = product.productID;
                row["ColumnName"] = product.productName;
                row["ColumnTonKho"] = product.tonKho;
                row["ColumnGiaBan"] = product.giaBan;
                dataTable.Rows.Add(row);
            }
            dtgvAssets.DataSource = dataTable;

            dtgvAssets.Refresh();
        }
    }
}
