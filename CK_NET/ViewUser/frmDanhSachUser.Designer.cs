namespace CK_NET
{
    partial class frmDanhSachUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.ColumnButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 450);
            this.panel2.TabIndex = 12;
            // 
            // dtgvUser
            // 
            this.dtgvUser.AllowUserToAddRows = false;
            this.dtgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnHoTen,
            this.ColumnDiaChi,
            this.ColumnViTri,
            this.ColumnPhone,
            this.ColumnUsername,
            this.ColumnPassword,
            this.ColumnButtonDelete});
            this.dtgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvUser.Location = new System.Drawing.Point(0, 77);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.ReadOnly = true;
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 24;
            this.dtgvUser.Size = new System.Drawing.Size(818, 373);
            this.dtgvUser.TabIndex = 5;
            this.dtgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellClick);
            this.dtgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellDoubleClick);
            // 
            // ColumnButtonDelete
            // 
            this.ColumnButtonDelete.DataPropertyName = "ColumnButtonDelete";
            this.ColumnButtonDelete.HeaderText = "";
            this.ColumnButtonDelete.MinimumWidth = 6;
            this.ColumnButtonDelete.Name = "ColumnButtonDelete";
            this.ColumnButtonDelete.ReadOnly = true;
            this.ColumnButtonDelete.Text = "Delete";
            this.ColumnButtonDelete.UseColumnTextForButtonValue = true;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.DataPropertyName = "ColumnPassword";
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.MinimumWidth = 6;
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.DataPropertyName = "ColumnUsername";
            this.ColumnUsername.HeaderText = "Username";
            this.ColumnUsername.MinimumWidth = 6;
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "ColumnPhone";
            this.ColumnPhone.HeaderText = "Số Điện Thoại";
            this.ColumnPhone.MinimumWidth = 6;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnViTri
            // 
            this.ColumnViTri.DataPropertyName = "ColumnViTri";
            this.ColumnViTri.HeaderText = "Vị Trí";
            this.ColumnViTri.MinimumWidth = 6;
            this.ColumnViTri.Name = "ColumnViTri";
            this.ColumnViTri.ReadOnly = true;
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.DataPropertyName = "ColumnDiaChi";
            this.ColumnDiaChi.HeaderText = "Địa Chỉ";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            this.ColumnDiaChi.ReadOnly = true;
            // 
            // ColumnHoTen
            // 
            this.ColumnHoTen.DataPropertyName = "ColumnHoTen";
            this.ColumnHoTen.HeaderText = "Họ và Tên";
            this.ColumnHoTen.MinimumWidth = 6;
            this.ColumnHoTen.Name = "ColumnHoTen";
            this.ColumnHoTen.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ColumnID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThemmoi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txtTukhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 77);
            this.panel1.TabIndex = 11;
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTukhoa.Location = new System.Drawing.Point(399, 32);
            this.txtTukhoa.Multiline = true;
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(149, 27);
            this.txtTukhoa.TabIndex = 7;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Location = new System.Drawing.Point(568, 32);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 27);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(308, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ khoá";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(699, 32);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(95, 27);
            this.btnThemmoi.TabIndex = 9;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách User";
            // 
            // frmDanhSachUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachUser";
            this.Text = "DanhsachUser";
            this.Load += new System.EventHandler(this.frmDanhSachUser_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTukhoa;
    }
}