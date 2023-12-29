using Bus_Tier;
using CK_NET.ViewAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_NET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ccbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản :>");
                return;
            }

            if (string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản. Tài khoản không được để trống:>");
                txtTaikhoan.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu. Mật khẩu không được để trống :>");
            }

            BSMember bSMember = new BSMember();
            DataTable dt = new DataTable();
            dt = bSMember.GetData("select * from member where username = '"+txtTaikhoan.Text+"' and password = '"+txtMatkhau.Text+ "' and viTri = '"+ccbLoaiTaiKhoan.Text+"'");
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dt.Rows[0][3].ToString() == "User")
                {
                    frmDanhSachAssets_User fUser = new frmDanhSachAssets_User();
                    this.Hide();
                    fUser.ShowDialog();
                }
                else
                {
                    Trangchu f = new Trangchu();
                    this.Hide();
                    f.ShowDialog();
                }
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            //this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
