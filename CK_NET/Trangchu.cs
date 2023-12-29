using CK_NET.ViewHoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CK_NET
{
    public partial class Trangchu : Form
    {

        public Trangchu()
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

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if(form.GetType() == typeof(Trangchu))
                {
                    form.Close();
                }
            }
            Login login = new Login();
            login.Show();
        }

        private void dsLinhkienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachAssets f = new frmDanhSachAssets();
            AddForm(f);
        }

        private void dsUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmDanhSachUser f = new frmDanhSachUser();
                AddForm(f);
        }

        private void dsHoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachHoaDon f = new frmDanhSachHoaDon();
            AddForm(f);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            Welcom f = new Welcom();
            AddForm(f);
        }
    }
}
