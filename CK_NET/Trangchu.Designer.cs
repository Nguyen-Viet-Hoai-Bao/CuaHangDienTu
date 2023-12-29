namespace CK_NET
{
    partial class Trangchu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsLinhkienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsHoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1056, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.thoatToolStripMenuItem.Text = "Đăng xuất";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.dangxuatToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Thoát";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsLinhkienToolStripMenuItem,
            this.dsUserToolStripMenuItem,
            this.dsHoadonToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // dsLinhkienToolStripMenuItem
            // 
            this.dsLinhkienToolStripMenuItem.Name = "dsLinhkienToolStripMenuItem";
            this.dsLinhkienToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dsLinhkienToolStripMenuItem.Text = "Danh sách Linh kiện";
            this.dsLinhkienToolStripMenuItem.Click += new System.EventHandler(this.dsLinhkienToolStripMenuItem_Click);
            // 
            // dsUserToolStripMenuItem
            // 
            this.dsUserToolStripMenuItem.Name = "dsUserToolStripMenuItem";
            this.dsUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dsUserToolStripMenuItem.Text = "Danh sách User";
            this.dsUserToolStripMenuItem.Click += new System.EventHandler(this.dsUserToolStripMenuItem_Click);
            // 
            // dsHoadonToolStripMenuItem
            // 
            this.dsHoadonToolStripMenuItem.Name = "dsHoadonToolStripMenuItem";
            this.dsHoadonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dsHoadonToolStripMenuItem.Text = "Danh sách Hóa đơn";
            this.dsHoadonToolStripMenuItem.Click += new System.EventHandler(this.dsHoadonToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            this.troGiupToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 488);
            this.panel1.TabIndex = 2;
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Linh Kiện Điện Tử";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsLinhkienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsHoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troGiupToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}