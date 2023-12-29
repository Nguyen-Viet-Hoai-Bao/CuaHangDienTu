namespace CK_NET
{
    partial class frmNewAssets
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prdName = new System.Windows.Forms.TextBox();
            this.prdGia = new System.Windows.Forms.TextBox();
            this.prdTonKho = new System.Windows.Forms.TextBox();
            this.btnSubmitProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(300, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(299, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tồn kho";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(299, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giá bán";
            // 
            // prdName
            // 
            this.prdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.prdName.Location = new System.Drawing.Point(425, 93);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(261, 27);
            this.prdName.TabIndex = 16;
            // 
            // prdGia
            // 
            this.prdGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prdGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.prdGia.Location = new System.Drawing.Point(425, 311);
            this.prdGia.Name = "prdGia";
            this.prdGia.Size = new System.Drawing.Size(129, 27);
            this.prdGia.TabIndex = 18;
            // 
            // prdTonKho
            // 
            this.prdTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.prdTonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.prdTonKho.Location = new System.Drawing.Point(425, 198);
            this.prdTonKho.Name = "prdTonKho";
            this.prdTonKho.Size = new System.Drawing.Size(129, 27);
            this.prdTonKho.TabIndex = 17;
            // 
            // btnSubmitProduct
            // 
            this.btnSubmitProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmitProduct.Location = new System.Drawing.Point(260, 416);
            this.btnSubmitProduct.Name = "btnSubmitProduct";
            this.btnSubmitProduct.Size = new System.Drawing.Size(142, 43);
            this.btnSubmitProduct.TabIndex = 19;
            this.btnSubmitProduct.Text = "submit";
            this.btnSubmitProduct.UseVisualStyleBackColor = true;
            this.btnSubmitProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(456, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 43);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnSubmitProduct);
            this.panelMain.Controls.Add(this.prdTonKho);
            this.panelMain.Controls.Add(this.prdGia);
            this.panelMain.Controls.Add(this.prdName);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label13);
            this.panelMain.Controls.Add(this.label14);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(882, 513);
            this.panelMain.TabIndex = 10;
            // 
            // frmNewAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.panelMain);
            this.Name = "frmNewAssets";
            this.Text = "frmNewAssets";
            this.Load += new System.EventHandler(this.frmNewAssets_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prdName;
        private System.Windows.Forms.TextBox prdGia;
        private System.Windows.Forms.TextBox prdTonKho;
        private System.Windows.Forms.Button btnSubmitProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelMain;
    }
}