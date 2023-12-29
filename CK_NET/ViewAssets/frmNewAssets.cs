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
    public partial class frmNewAssets : Form
    {
        public frmNewAssets()
        {
            InitializeComponent();
        }

        private void frmNewAssets_Load(object sender, EventArgs e)
        {

        }
        private void AddForm(Form f)
        {
            this.panelMain.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            f.Show();
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productName = prdName.Text;
            product.tonKho = Int32.Parse(prdTonKho.Text);
            product.giaBan = Int32.Parse(prdGia.Text);

            BSProduct bSProduct = new BSProduct();
            bSProduct.insert(product);
            MessageBox.Show("Đăng ký sản phẩm thành công!");
            prdName.Clear();
            prdTonKho.Clear();
            prdGia.Clear();

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
