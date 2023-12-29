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

namespace CK_NET
{
    public partial class frmDanhSachAssets : Form
    {
        DataTable dataTable;
        public frmDanhSachAssets()
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

        private void DanhSachAssets_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmNewAssets f = new frmNewAssets();
            AddForm(f);
        }   

        private void dtgvAssets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var msv = dtgvAssets.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString();
                var name = dtgvAssets.Rows[e.RowIndex].Cells["ColumnName"].Value.ToString();
                var tonKho = dtgvAssets.Rows[e.RowIndex].Cells["ColumnTonKho"].Value.ToString();
                var gia = dtgvAssets.Rows[e.RowIndex].Cells["ColumnGiaBan"].Value.ToString();

                frmAssets f = new frmAssets(Int32.Parse(msv), name, Int32.Parse(tonKho), Int32.Parse(gia));
                AddForm(f);
            }
        }


        private void dtgvAssets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvAssets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0)
            {
                if(e.ColumnIndex == dtgvAssets.Columns["ColumnBtnDelete"].Index)
                {
                    var id = dtgvAssets.Rows[e.RowIndex].Cells["ColumnID"].Value.ToString();
                    BSProduct bSProduct = new BSProduct();

                    int max = bSProduct.getMaxProductID();
                    var result = bSProduct.deleteProduct(Int32.Parse(id));

                    if (max == Int32.Parse(id))
                    {
                        bSProduct.resetID(max-1);
                    }

                    if(result == 1) 
                    {
                        MessageBox.Show("Xoa thanh cong");
                        load();
                    }
                }
            }
        }
    }
}
