namespace CK_NET.ViewHoaDon
{
    partial class frmDanhSachHoaDon
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
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ColumnIDHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonShow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(654, 43);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(95, 27);
            this.btnThemmoi.TabIndex = 9;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIDHoaDon,
            this.ColumnIDMember,
            this.ColumnTongTien,
            this.ColumnButtonShow,
            this.ColumnButtonDelete});
            this.dtgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(800, 368);
            this.dtgvHoaDon.TabIndex = 5;
            this.dtgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHoaDon_CellClick);
            // 
            // ColumnIDHoaDon
            // 
            this.ColumnIDHoaDon.DataPropertyName = "ColumnIDHoaDon";
            this.ColumnIDHoaDon.HeaderText = "ID";
            this.ColumnIDHoaDon.MinimumWidth = 6;
            this.ColumnIDHoaDon.Name = "ColumnIDHoaDon";
            this.ColumnIDHoaDon.ReadOnly = true;
            // 
            // ColumnIDMember
            // 
            this.ColumnIDMember.DataPropertyName = "ColumnIDMember";
            this.ColumnIDMember.HeaderText = "Họ và Tên";
            this.ColumnIDMember.MinimumWidth = 6;
            this.ColumnIDMember.Name = "ColumnIDMember";
            this.ColumnIDMember.ReadOnly = true;
            // 
            // ColumnTongTien
            // 
            this.ColumnTongTien.DataPropertyName = "ColumnTongTien";
            this.ColumnTongTien.HeaderText = "Tổng tiền";
            this.ColumnTongTien.MinimumWidth = 6;
            this.ColumnTongTien.Name = "ColumnTongTien";
            this.ColumnTongTien.ReadOnly = true;
            // 
            // ColumnButtonShow
            // 
            this.ColumnButtonShow.DataPropertyName = "ColumnButtonShow";
            this.ColumnButtonShow.HeaderText = "";
            this.ColumnButtonShow.MinimumWidth = 6;
            this.ColumnButtonShow.Name = "ColumnButtonShow";
            this.ColumnButtonShow.ReadOnly = true;
            this.ColumnButtonShow.Text = "Xem chi tiết";
            this.ColumnButtonShow.UseColumnTextForButtonValue = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThemmoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvHoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 368);
            this.panel2.TabIndex = 12;
            // 
            // frmDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhSachHoaDon";
            this.Text = "DanhsachHoaDon";
            this.Load += new System.EventHandler(this.frmDanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongTien;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonShow;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}