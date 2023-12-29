using Bus_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CK_NET
{
    public partial class frmUser : Form
    {
        private int id;
        private string name;
        private string diaChi;
        private string viTri;
        private int phone;
        private string username;
        private string password;
        public frmUser(int id, string name, string diaChi, string viTri, int phone, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.diaChi = diaChi;
            this.viTri = viTri;
            this.phone = phone;
            this.username = username;
            this.password = password;
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
        private void User_Load(object sender, EventArgs e)
        {
            String ID = id.ToString();
            if (string.IsNullOrEmpty(ID))
            {
                this.Text = "Them san pham";
            }
            else
            {
                this.Text = "Cap nhat thong tin san pham";
                Member member = new Member();

                lbmemberid.Text = this.id.ToString();
                lbname.Text = this.name;
                lbdiachi.Text = this.diaChi;
                lbvitri.Text = this.viTri;
                lbphone.Text = this.phone.ToString();
                lbusername.Text = this.username;
                lbpwd.Text = this.password;

                txtMemberName.Text = this.name;
                txtMemberDiaChi.Text = this.diaChi;
                txtMemberViTri.Text = this.viTri;
                txtMemberPhone.Text = this.phone.ToString();
                txtMemberUsername.Text = this.username;
                txtMemberPwd.Text = this.password;
            }
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            member.memberID = Int32.Parse(lbmemberid.Text);
            member.hoTen = txtMemberName.Text;
            member.diaChi = txtMemberDiaChi.Text;
            member.viTri = txtMemberViTri.Text;
            member.soDienThoai = Int32.Parse(txtMemberPhone.Text);
            member.username = txtMemberUsername.Text;
            member.password = txtMemberPwd.Text;

            BSMember bSMember = new BSMember();
            bSMember.updateMember(member);
            MessageBox.Show("Cap nhat user thanh cong");
            frmDanhSachUser f = new frmDanhSachUser();
            AddForm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDanhSachUser f = new frmDanhSachUser();
            AddForm(f);
        }
    }
}
