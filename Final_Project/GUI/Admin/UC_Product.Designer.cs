namespace Final_Project.GUI.Admin
{
    partial class UC_Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv_product = new System.Windows.Forms.DataGridView();
            this.Panbr = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_originproduct = new System.Windows.Forms.TextBox();
            this.txb_warrantyproduct = new System.Windows.Forms.TextBox();
            this.txb_discountproduct = new System.Windows.Forms.TextBox();
            this.tbx_idpro = new System.Windows.Forms.TextBox();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.btn_Addproduct = new System.Windows.Forms.Button();
            this.txb_nameproduct = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_Removeproduct = new System.Windows.Forms.Button();
            this.btn_Editproduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_product)).BeginInit();
            this.Panbr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_product
            // 
            this.dtgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_product.Location = new System.Drawing.Point(3, 11);
            this.dtgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_product.Name = "dtgv_product";
            this.dtgv_product.RowHeadersWidth = 62;
            this.dtgv_product.RowTemplate.Height = 28;
            this.dtgv_product.Size = new System.Drawing.Size(556, 340);
            this.dtgv_product.TabIndex = 13;
            this.dtgv_product.Click += new System.EventHandler(this.dtgvproduct_Click);
            // 
            // Panbr
            // 
            this.Panbr.Controls.Add(this.num_Price);
            this.Panbr.Controls.Add(this.btn_Clear);
            this.Panbr.Controls.Add(this.label4);
            this.Panbr.Controls.Add(this.label3);
            this.Panbr.Controls.Add(this.label1);
            this.Panbr.Controls.Add(this.txb_originproduct);
            this.Panbr.Controls.Add(this.txb_warrantyproduct);
            this.Panbr.Controls.Add(this.txb_discountproduct);
            this.Panbr.Controls.Add(this.tbx_idpro);
            this.Panbr.Controls.Add(this.cb_brand);
            this.Panbr.Controls.Add(this.btn_Addproduct);
            this.Panbr.Controls.Add(this.txb_nameproduct);
            this.Panbr.Controls.Add(this.Tên);
            this.Panbr.Controls.Add(this.btn_Removeproduct);
            this.Panbr.Controls.Add(this.btn_Editproduct);
            this.Panbr.Controls.Add(this.label2);
            this.Panbr.Location = new System.Drawing.Point(588, 11);
            this.Panbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panbr.Name = "Panbr";
            this.Panbr.Size = new System.Drawing.Size(450, 423);
            this.Panbr.TabIndex = 14;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(27, 308);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 32);
            this.btn_Clear.TabIndex = 51;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Warranty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Khuyến mãi";
            // 
            // txb_originproduct
            // 
            this.txb_originproduct.Location = new System.Drawing.Point(158, 274);
            this.txb_originproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_originproduct.Name = "txb_originproduct";
            this.txb_originproduct.Size = new System.Drawing.Size(178, 22);
            this.txb_originproduct.TabIndex = 47;
            // 
            // txb_warrantyproduct
            // 
            this.txb_warrantyproduct.Location = new System.Drawing.Point(158, 233);
            this.txb_warrantyproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_warrantyproduct.Name = "txb_warrantyproduct";
            this.txb_warrantyproduct.Size = new System.Drawing.Size(178, 22);
            this.txb_warrantyproduct.TabIndex = 46;
            // 
            // txb_discountproduct
            // 
            this.txb_discountproduct.Location = new System.Drawing.Point(158, 189);
            this.txb_discountproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_discountproduct.Name = "txb_discountproduct";
            this.txb_discountproduct.Size = new System.Drawing.Size(178, 22);
            this.txb_discountproduct.TabIndex = 45;
            // 
            // tbx_idpro
            // 
            this.tbx_idpro.Location = new System.Drawing.Point(158, 15);
            this.tbx_idpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_idpro.Name = "tbx_idpro";
            this.tbx_idpro.Size = new System.Drawing.Size(178, 22);
            this.tbx_idpro.TabIndex = 44;
            // 
            // cb_brand
            // 
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(158, 56);
            this.cb_brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(181, 24);
            this.cb_brand.TabIndex = 13;
            // 
            // btn_Addproduct
            // 
            this.btn_Addproduct.Location = new System.Drawing.Point(27, 359);
            this.btn_Addproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Addproduct.Name = "btn_Addproduct";
            this.btn_Addproduct.Size = new System.Drawing.Size(100, 32);
            this.btn_Addproduct.TabIndex = 42;
            this.btn_Addproduct.Text = "Thêm";
            this.btn_Addproduct.UseVisualStyleBackColor = true;
            this.btn_Addproduct.Click += new System.EventHandler(this.btn_Addproduct_Click);
            // 
            // txb_nameproduct
            // 
            this.txb_nameproduct.Location = new System.Drawing.Point(158, 99);
            this.txb_nameproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_nameproduct.Name = "txb_nameproduct";
            this.txb_nameproduct.Size = new System.Drawing.Size(178, 22);
            this.txb_nameproduct.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(24, 150);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(30, 17);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Gía";
            // 
            // btn_Removeproduct
            // 
            this.btn_Removeproduct.Location = new System.Drawing.Point(184, 359);
            this.btn_Removeproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Removeproduct.Name = "btn_Removeproduct";
            this.btn_Removeproduct.Size = new System.Drawing.Size(100, 32);
            this.btn_Removeproduct.TabIndex = 3;
            this.btn_Removeproduct.Text = "Xoá ";
            this.btn_Removeproduct.UseVisualStyleBackColor = true;
            this.btn_Removeproduct.Click += new System.EventHandler(this.btn_Removeproduct_Click);
            // 
            // btn_Editproduct
            // 
            this.btn_Editproduct.Location = new System.Drawing.Point(327, 359);
            this.btn_Editproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Editproduct.Name = "btn_Editproduct";
            this.btn_Editproduct.Size = new System.Drawing.Size(100, 32);
            this.btn_Editproduct.TabIndex = 2;
            this.btn_Editproduct.Text = "Sửa";
            this.btn_Editproduct.UseVisualStyleBackColor = true;
            this.btn_Editproduct.Click += new System.EventHandler(this.btn_Editproduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên sản phẩm";
            // 
            // num_Price
            // 
            this.num_Price.Location = new System.Drawing.Point(158, 148);
            this.num_Price.Maximum = new decimal(new int[] {
            1241513984,
            370409800,
            542101,
            0});
            this.num_Price.Name = "num_Price";
            this.num_Price.Size = new System.Drawing.Size(178, 22);
            this.num_Price.TabIndex = 52;
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panbr);
            this.Controls.Add(this.dtgv_product);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(1136, 456);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_product)).EndInit();
            this.Panbr.ResumeLayout(false);
            this.Panbr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_product;
        private System.Windows.Forms.Panel Panbr;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_originproduct;
        private System.Windows.Forms.TextBox txb_warrantyproduct;
        private System.Windows.Forms.TextBox txb_discountproduct;
        private System.Windows.Forms.TextBox tbx_idpro;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Button btn_Addproduct;
        private System.Windows.Forms.TextBox txb_nameproduct;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_Removeproduct;
        private System.Windows.Forms.Button btn_Editproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Price;
    }
}
