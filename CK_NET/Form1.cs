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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSMember bSMember = new BSMember();
            List<Member> members = bSMember.getListMember();
            listBox1.Items.Clear();
            listBox1.ValueMember = "memberID";
            for(int i=0; i<members.Count; i++)
            {
                listBox1.Items.Add(members[i].ToString())    ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BSProduct bSProduct = new BSProduct();
            List<Product> products = bSProduct.getListProduct();
            listBox1.Items.Clear();
            listBox1.ValueMember = "productID";
            for (int i = 0; i < products.Count; i++)
            {
                listBox1.Items.Add(products[i].ToString());
            }
            //listBox1.DataSource= products;
        }

        private void btnSubmitPrd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.productName = prdName.Text;
            product.tonKho = Int32.Parse(prdTonKho.Text);
            product.giaBan = Int32.Parse(prdGia.Text);

            BSProduct bSProduct = new BSProduct();
            bSProduct.insert(product);
            prdName.Clear();
            prdTonKho.Clear();
            prdGia.Clear();

            listBox1.Items.Clear();
            listBox1.ValueMember = "masp";
            List<Product> products = bSProduct.getListProduct();
            for (int i = 0; i < products.Count; i++)
            {
                listBox1.Items.Add(products[i].ToString());
            }
        }

        private void btnSubmitMb_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.hoTen = mbName.Text;
            member.diaChi = mbDiaChi.Text;
            member.viTri = mbViTri.Text;
            member.soDienThoai = Int32.Parse(mbPhone.Text);
            member.username= mbUsername.Text;
            member.password= mbPassword.Text;

            BSMember bSMember = new BSMember();
            bSMember.insert(member); 
            mbName.Clear();
            mbDiaChi.Clear();
            mbViTri.Clear();
            mbPhone.Clear();
            mbUsername.Clear();
            mbPassword.Clear();

            listBox1.Items.Clear();
            listBox1.ValueMember = "masp";
            List<Member> members = bSMember.getListMember();
            for (int i = 0; i < members.Count; i++)
            {
                listBox1.Items.Add(members[i].ToString());
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        

        private void UpdateMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            if (listBox1.SelectedIndex != -1)
            {
                int selectedRowIndex = listBox1.SelectedIndex;
                BSMember bSMember = new BSMember();
                List<Member> members = bSMember.getListMember();
                lbmemberid.Text = members[selectedRowIndex].memberID.ToString();
                lbname.Text = members[selectedRowIndex].hoTen.ToString();
                lbdiachi.Text = members[selectedRowIndex].diaChi.ToString();
                lbvitri.Text = members[selectedRowIndex].viTri.ToString();
                lbphone.Text = members[selectedRowIndex].soDienThoai.ToString();
                lbusername.Text = members[selectedRowIndex].username.ToString();
                lbpwd.Text = members[selectedRowIndex].password.ToString();

                txtMemberName.Text = members[selectedRowIndex].hoTen.ToString();
                txtMemberDiaChi.Text = members[selectedRowIndex].diaChi.ToString();
                txtMemberViTri.Text = members[selectedRowIndex].viTri.ToString();
                txtMemberPhone.Text = members[selectedRowIndex].soDienThoai.ToString();
                txtMemberUsername.Text = members[selectedRowIndex].username.ToString();
                txtMemberPwd.Text = members[selectedRowIndex].password.ToString();
            }
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            if (listBox1.SelectedIndex != -1)
            {
                int selectedRowIndex = listBox1.SelectedIndex;
                BSProduct bSProduct = new BSProduct();
                List<Product> products = bSProduct.getListProduct();
                /*int selectedID = ((Product)listBox1.Items[selectedRowIndex]).productID;
                BSProduct bSProduct = new BSProduct();
                product = bSProduct.GetProductFromID(selectedID);*/
                label17.Text = products[selectedRowIndex].productID.ToString();
                label18.Text = products[selectedRowIndex].productName.ToString();
                label19.Text = products[selectedRowIndex].tonKho.ToString();
                label20.Text = products[selectedRowIndex].giaBan.ToString();

                prdUpdateName.Text = products[selectedRowIndex].productName.ToString();
                prdUpdateTonKho.Text = products[selectedRowIndex].tonKho.ToString();
                prdUpdateGia.Text = products[selectedRowIndex].giaBan.ToString();
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

        }
        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.memberID = Int32.Parse(lbmemberid.Text);
            member.hoTen = txtMemberName.Text;
            member.diaChi = txtMemberDiaChi.Text;
            member.viTri= txtMemberViTri.Text;
            member.soDienThoai = Int32.Parse(txtMemberPhone.Text);
            member.username = txtMemberUsername.Text;
            member.password = txtMemberPwd.Text;

            BSMember bSMember = new BSMember();
            bSMember.updateMember(member);

            lbmemberid.Text = "";
            lbname.Text = "";
            lbdiachi.Text = "";
            lbvitri.Text = "";
            lbphone.Text = "";
            lbusername.Text = "";
            lbpwd.Text = "";
            txtMemberName.Clear();
            txtMemberDiaChi.Clear();
            txtMemberViTri.Clear();
            txtMemberPhone.Clear();
            txtMemberUsername.Clear();
            txtMemberPwd.Clear();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            BSProduct bSProduct = new BSProduct();

            int selectedRowIndex = listBox1.SelectedIndex;
            List<Product> products = bSProduct.getListProduct();
            bSProduct.deleteProduct(products[selectedRowIndex].productID);
            products.Clear();
            products = bSProduct.getListProduct();
            listBox1.Items.Clear();
            listBox1.ValueMember = "masp";
            for (int i = 0; i < products.Count; i++)
            {
                listBox1.Items.Add(products[i].ToString());
            }
        }

        private void DeleteMember_Click(object sender, EventArgs e)
        {
            BSMember bSMember = new BSMember();

            int selectedRowIndex = listBox1.SelectedIndex;
            List<Member> members= bSMember.getListMember();
            bSMember.deleteMember(members[selectedRowIndex].memberID);
            members.Clear();
            members = bSMember.getListMember();
            listBox1.Items.Clear();
            listBox1.ValueMember = "memberID";
            for (int i = 0; i < members.Count; i++)
            {
                listBox1.Items.Add(members[i].ToString());
            }
        }
    }
}
