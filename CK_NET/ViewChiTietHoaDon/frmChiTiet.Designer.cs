namespace CK_NET.ViewChiTietHoaDon
{
    partial class frmChiTiet
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
            this.dtgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChiTietHoaDon
            // 
            this.dtgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnSoLuong,
            this.ColumnGia});
            this.dtgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietHoaDon.Name = "dtgvChiTietHoaDon";
            this.dtgvChiTietHoaDon.ReadOnly = true;
            this.dtgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dtgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgvChiTietHoaDon.Size = new System.Drawing.Size(800, 392);
            this.dtgvChiTietHoaDon.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(290, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.Location = new System.Drawing.Point(133, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(53, 20);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "label3";
            // 
            // lbMember
            // 
            this.lbMember.AutoSize = true;
            this.lbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMember.Location = new System.Drawing.Point(431, 20);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(53, 20);
            this.lbMember.TabIndex = 16;
            this.lbMember.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbMember);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvChiTietHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 392);
            this.panel2.TabIndex = 18;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.DataPropertyName = "ColumnProduct";
            this.ColumnProduct.HeaderText = "Tên sản phẩm";
            this.ColumnProduct.MinimumWidth = 6;
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.DataPropertyName = "ColumnSoLuong";
            this.ColumnSoLuong.HeaderText = "Số lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            // 
            // ColumnGia
            // 
            this.ColumnGia.DataPropertyName = "ColumnGia";
            this.ColumnGia.HeaderText = "Giá Bán";
            this.ColumnGia.MinimumWidth = 6;
            this.ColumnGia.Name = "ColumnGia";
            this.ColumnGia.ReadOnly = true;
            // 
            // frmChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChiTiet";
            this.Text = "frmChiTiet";
            this.Load += new System.EventHandler(this.frmChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChiTietHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGia;
    }
}