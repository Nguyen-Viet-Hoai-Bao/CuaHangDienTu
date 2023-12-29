namespace CK_NET.ViewAssets
{
    partial class frmDanhSachAssets_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvAssets = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssets)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(916, 28);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoatToolStripMenuItem.Text = "Đăng xuất";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Thoát";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // dtgvAssets
            // 
            this.dtgvAssets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAssets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnTonKho,
            this.ColumnGiaBan});
            this.dtgvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAssets.Location = new System.Drawing.Point(0, 0);
            this.dtgvAssets.Name = "dtgvAssets";
            this.dtgvAssets.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAssets.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAssets.RowHeadersWidth = 51;
            this.dtgvAssets.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvAssets.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvAssets.RowTemplate.Height = 24;
            this.dtgvAssets.Size = new System.Drawing.Size(916, 404);
            this.dtgvAssets.TabIndex = 14;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ColumnID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ColumnID.DefaultCellStyle = dataGridViewCellStyle1;
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(152, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh sách Linh kiện";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txtTukhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 79);
            this.panel1.TabIndex = 13;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiem.Location = new System.Drawing.Point(733, 27);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 27);
            this.btnTimkiem.TabIndex = 19;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTukhoa.Location = new System.Drawing.Point(556, 24);
            this.txtTukhoa.Multiline = true;
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(149, 27);
            this.txtTukhoa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(468, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Từ khoá";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvAssets);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 404);
            this.panel2.TabIndex = 15;
            // 
            // frmDanhSachAssets_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmDanhSachAssets_User";
            this.Text = "frmDanhSachAssets_User";
            this.Load += new System.EventHandler(this.frmDanhSachAssets_User_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAssets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvAssets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTimkiem;
    }
}