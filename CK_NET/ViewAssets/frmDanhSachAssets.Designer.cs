namespace CK_NET
{
    partial class frmDanhSachAssets
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
            this.dtgvAssets = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssets)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvAssets
            // 
            this.dtgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnTonKho,
            this.ColumnGiaBan,
            this.ColumnBtnDelete});
            this.dtgvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAssets.Location = new System.Drawing.Point(0, 0);
            this.dtgvAssets.Name = "dtgvAssets";
            this.dtgvAssets.ReadOnly = true;
            this.dtgvAssets.RowHeadersWidth = 51;
            this.dtgvAssets.RowTemplate.Height = 24;
            this.dtgvAssets.Size = new System.Drawing.Size(901, 398);
            this.dtgvAssets.TabIndex = 0;
            this.dtgvAssets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAssets_CellClick);
            this.dtgvAssets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAssets_CellContentClick);
            this.dtgvAssets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAssets_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ColumnID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            this.ColumnName.HeaderText = "Tên sản phẩm";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnTonKho
            // 
            this.ColumnTonKho.DataPropertyName = "ColumnTonKho";
            this.ColumnTonKho.HeaderText = "Tồn Kho";
            this.ColumnTonKho.MinimumWidth = 6;
            this.ColumnTonKho.Name = "ColumnTonKho";
            this.ColumnTonKho.ReadOnly = true;
            // 
            // ColumnGiaBan
            // 
            this.ColumnGiaBan.DataPropertyName = "ColumnGiaBan";
            this.ColumnGiaBan.HeaderText = "Giá Bán";
            this.ColumnGiaBan.MinimumWidth = 6;
            this.ColumnGiaBan.Name = "ColumnGiaBan";
            this.ColumnGiaBan.ReadOnly = true;
            // 
            // ColumnBtnDelete
            // 
            this.ColumnBtnDelete.DataPropertyName = "ColumnBtnDelete";
            this.ColumnBtnDelete.HeaderText = "Delete";
            this.ColumnBtnDelete.MinimumWidth = 6;
            this.ColumnBtnDelete.Name = "ColumnBtnDelete";
            this.ColumnBtnDelete.ReadOnly = true;
            this.ColumnBtnDelete.Text = "Xóa";
            this.ColumnBtnDelete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(421, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khoá";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTukhoa.Location = new System.Drawing.Point(505, 26);
            this.txtTukhoa.Multiline = true;
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(149, 27);
            this.txtTukhoa.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Location = new System.Drawing.Point(671, 26);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 27);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(794, 26);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(95, 27);
            this.btnThemmoi.TabIndex = 4;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh sách Linh kiện";
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
            this.panel1.Size = new System.Drawing.Size(901, 86);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvAssets);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 398);
            this.panel2.TabIndex = 13;
            // 
            // frmDanhSachAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhSachAssets";
            this.Text = "Danh sách Linh kiện";
            this.Load += new System.EventHandler(this.DanhSachAssets_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAssets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaBan;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBtnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}