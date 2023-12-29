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
    public partial class frmDanhSachUser : Form
    {
        DataTable dataTable;
        public frmDanhSachUser()
        {
            InitializeComponent();
        }
        public void load()
        {
            dataTable= new DataTable();
            BSMember bSMember = new BSMember();
            List<Member> members = bSMember.getListMember();

            dataTable.Columns.Add("ColumnId", typeof(int));
            dataTable.Columns.Add("ColumnHoTen", typeof(string));
            dataTable.Columns.Add("ColumnDiaChi", typeof(string));
            dataTable.Columns.Add("ColumnViTri", typeof(string));
            dataTable.Columns.Add("ColumnPhone", typeof(int));
            dataTable.Columns.Add("ColumnUsername", typeof(String));
            dataTable.Columns.Add("ColumnPassword", typeof(String));

            dataTable.Clear();
            foreach (Member member in members)
            {
                DataRow row = dataTable.NewRow();
                row["ColumnId"] = member.memberID;
                row["ColumnHoTen"] = member.hoTen;
                row["ColumnDiaChi"] = member.diaChi;
                row["ColumnViTri"] = member.viTri;
                row["ColumnPhone"] = member.soDienThoai;
                row["ColumnUsername"] = member.username;
                row["ColumnPassword"] = member.password;

                dataTable.Rows.Add(row);
            }
            dtgvUser.DataSource = dataTable;

            dtgvUser.Refresh();
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
        private void frmDanhSachUser_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmNewUser f = new frmNewUser();
            AddForm(f);
        }

        private void dtgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dtgvUser.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString();
                var name = dtgvUser.Rows[e.RowIndex].Cells["ColumnHoTen"].Value.ToString();
                var diaChi = dtgvUser.Rows[e.RowIndex].Cells["ColumnDiaChi"].Value.ToString();
                var viTri = dtgvUser.Rows[e.RowIndex].Cells["ColumnViTri"].Value.ToString();
                var phone = dtgvUser.Rows[e.RowIndex].Cells["ColumnPhone"].Value.ToString();
                var username = dtgvUser.Rows[e.RowIndex].Cells["ColumnUsername"].Value.ToString();
                var password = dtgvUser.Rows[e.RowIndex].Cells["ColumnPassword"].Value.ToString();

                frmUser f = new frmUser(Int32.Parse(msv), name, diaChi, viTri, Int32.Parse(phone), username, password);
                AddForm(f);
            }
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dtgvUser.Columns["ColumnButtonDelete"].Index)
                {
                    var id = dtgvUser.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString();
                    BSMember bSMember= new BSMember();

                    int max = bSMember.getMaxMemberID();
                    var result = bSMember.deleteMember(Int32.Parse(id));

                    if(max == Int32.Parse(id))
                    {
                        bSMember.resetID(max - 1);
                    }
                    if (result == 1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        load();
                    }
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String name = txtTukhoa.Text;
            BSMember bSMember= new BSMember();
            List<Member> members = bSMember.searchMember(name);

            dataTable = new DataTable();
            dataTable.Columns.Add("ColumnId", typeof(int));
            dataTable.Columns.Add("ColumnHoTen", typeof(string));
            dataTable.Columns.Add("ColumnDiaChi", typeof(string));
            dataTable.Columns.Add("ColumnViTri", typeof(string));
            dataTable.Columns.Add("ColumnPhone", typeof(int));
            dataTable.Columns.Add("ColumnUsername", typeof(String));
            dataTable.Columns.Add("ColumnPassword", typeof(String));
            foreach (Member member in members)
            {
                DataRow row = dataTable.NewRow();
                row["ColumnId"] = member.memberID;
                row["ColumnHoTen"] = member.hoTen;
                row["ColumnDiaChi"] = member.diaChi;
                row["ColumnViTri"] = member.viTri;
                row["ColumnPhone"] = member.soDienThoai;
                row["ColumnUsername"] = member.username;
                row["ColumnPassword"] = member.password;
                dataTable.Rows.Add(row);
            }
            dtgvUser.DataSource = dataTable;

            dtgvUser.Refresh();
        }

    }
}
