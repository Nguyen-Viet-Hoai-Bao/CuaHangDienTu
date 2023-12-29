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
    public partial class frmAssets : Form
    {
        private int id;
        private string name;
        private int tonKho;
        private int gia;
        public frmAssets(int id, string name, int tonKho, int gia)
        {
            this.id = id;
            this.name = name;
            this.tonKho = tonKho;
            this.gia = gia;
            InitializeComponent();
        }

        private void AddForm(Form f)
        {
            this.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Controls.Add(f);
            f.Show();
        }
        private void frmAssets_Load(object sender, EventArgs e)
        {
            String ID = id.ToString();
            if (string.IsNullOrEmpty(ID))
            {
                this.Text = "Them san pham";
            }
            else
            {
                this.Text = "Cap nhat thong tin san pham";
                Product product = new Product();

                label17.Text = this.id.ToString();
                label18.Text = this.name;
                label19.Text = this.tonKho.ToString();
                label20.Text = this.gia.ToString();

                prdUpdateName.Text = this.name;
                prdUpdateTonKho.Text = this.tonKho.ToString();
                prdUpdateGia.Text = this.gia.ToString();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productName = prdUpdateName.Text;
            product.tonKho = Int32.Parse(prdUpdateTonKho.Text);
            product.giaBan = Int32.Parse(prdUpdateGia.Text);
            product.productID = Int32.Parse(label17.Text);

            BSProduct bSProduct = new BSProduct();
            bSProduct.updateProduct(product);

            prdUpdateName.Clear();
            prdUpdateTonKho.Clear();
            prdUpdateGia.Clear();
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";

            MessageBox.Show("Cap nhat san pham thanh cong");
            frmDanhSachAssets f = new frmDanhSachAssets();
            AddForm(f);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmDanhSachAssets f = new frmDanhSachAssets();
            AddForm(f);
        }
    }
}
