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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }
        private void btnSubmitMb_Click_1(object sender, EventArgs e)
        {
            Member member = new Member();
            member.hoTen = mbName.Text;
            member.diaChi = mbDiaChi.Text;
            member.viTri = mbViTri.Text;
            member.soDienThoai = Int32.Parse(mbPhone.Text);
            member.username = mbUsername.Text;
            member.password = mbPassword.Text;

            BSMember bSMember = new BSMember();
            bSMember.insert(member);
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
