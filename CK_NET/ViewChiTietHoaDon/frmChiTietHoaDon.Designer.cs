namespace CK_NET.ViewChiTietHoaDon
{
    partial class frmChiTietHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dtgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên người dùng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sản phẩm";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(118, 18);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(294, 24);
            this.comboBox4.TabIndex = 9;
            // 
            // dtgvChiTietHoaDon
            // 
            this.dtgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnProductName,
            this.ColumnSoLuong,
            this.ColumnGiaBan,
            this.ColumnDelete});
            this.dtgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietHoaDon.Name = "dtgvChiTietHoaDon";
            this.dtgvChiTietHoaDon.ReadOnly = true;
            this.dtgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgvChiTietHoaDon.Size = new System.Drawing.Size(800, 338);
            this.dtgvChiTietHoaDon.TabIndex = 10;
            this.dtgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChiTietHoaDon_CellClick);
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.DataPropertyName = "ColumnSTT";
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.MinimumWidth = 6;
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "ColumnProductName";
            this.ColumnProductName.HeaderText = "Sản phẩm";
            this.ColumnProductName.MinimumWidth = 6;
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.DataPropertyName = "ColumnSoLuong";
            this.ColumnSoLuong.HeaderText = "Số lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            // 
            // ColumnGiaBan
            // 
            this.ColumnGiaBan.DataPropertyName = "ColumnGiaBan";
            this.ColumnGiaBan.HeaderText = "Giá bán";
            this.ColumnGiaBan.MinimumWidth = 6;
            this.ColumnGiaBan.Name = "ColumnGiaBan";
            this.ColumnGiaBan.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.DataPropertyName = "ColumnDelete";
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.MinimumWidth = 6;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "ColumnDelete";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSubmit.Location = new System.Drawing.Point(684, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 34);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Lưu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoLuong.Location = new System.Drawing.Point(440, 62);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(50, 22);
            this.txtSoLuong.TabIndex = 14;
            this.txtSoLuong.Text = "1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(542, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(427, 18);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(63, 16);
            this.lbTongTien.TabIndex = 16;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTongTien.Location = new System.Drawing.Point(496, 18);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(101, 22);
            this.txtTongTien.TabIndex = 17;
            this.txtTongTien.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvChiTietHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 338);
            this.panel2.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Location = new System.Drawing.Point(684, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.DataGridView dtgvChiTietHoaDon;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaBan;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
    }
}