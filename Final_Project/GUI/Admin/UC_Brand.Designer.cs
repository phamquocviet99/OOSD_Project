namespace Final_Project.GUI.Admin
{
    partial class UC_Brand
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
            this.Panbr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cate = new System.Windows.Forms.ComboBox();
            this.btn_AddBr = new System.Windows.Forms.Button();
            this.txb_desbr = new System.Windows.Forms.TextBox();
            this.Tên = new System.Windows.Forms.Label();
            this.btn_RemoveBr = new System.Windows.Forms.Button();
            this.btn_editbr = new System.Windows.Forms.Button();
            this.txb_namebrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_brand = new System.Windows.Forms.DataGridView();
            this.Panbr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_brand)).BeginInit();
            this.SuspendLayout();
            // 
            // Panbr
            // 
            this.Panbr.Controls.Add(this.label1);
            this.Panbr.Controls.Add(this.cb_cate);
            this.Panbr.Controls.Add(this.btn_AddBr);
            this.Panbr.Controls.Add(this.txb_desbr);
            this.Panbr.Controls.Add(this.Tên);
            this.Panbr.Controls.Add(this.btn_RemoveBr);
            this.Panbr.Controls.Add(this.btn_editbr);
            this.Panbr.Controls.Add(this.txb_namebrand);
            this.Panbr.Controls.Add(this.label2);
            this.Panbr.Location = new System.Drawing.Point(575, 19);
            this.Panbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panbr.Name = "Panbr";
            this.Panbr.Size = new System.Drawing.Size(450, 342);
            this.Panbr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "chọn catelogy";
            // 
            // cb_cate
            // 
            this.cb_cate.FormattingEnabled = true;
            this.cb_cate.Location = new System.Drawing.Point(158, 145);
            this.cb_cate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cate.Name = "cb_cate";
            this.cb_cate.Size = new System.Drawing.Size(181, 24);
            this.cb_cate.TabIndex = 13;
            // 
            // btn_AddBr
            // 
            this.btn_AddBr.Location = new System.Drawing.Point(44, 294);
            this.btn_AddBr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddBr.Name = "btn_AddBr";
            this.btn_AddBr.Size = new System.Drawing.Size(100, 32);
            this.btn_AddBr.TabIndex = 42;
            this.btn_AddBr.Text = "Thêm danh mục";
            this.btn_AddBr.UseVisualStyleBackColor = true;
            this.btn_AddBr.Click += new System.EventHandler(this.btn_AddBr_Click);
            // 
            // txb_desbr
            // 
            this.txb_desbr.Location = new System.Drawing.Point(158, 99);
            this.txb_desbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_desbr.Name = "txb_desbr";
            this.txb_desbr.Size = new System.Drawing.Size(178, 22);
            this.txb_desbr.TabIndex = 41;
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(24, 99);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(43, 17);
            this.Tên.TabIndex = 40;
            this.Tên.Text = "Mô tả";
            // 
            // btn_RemoveBr
            // 
            this.btn_RemoveBr.Location = new System.Drawing.Point(174, 294);
            this.btn_RemoveBr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveBr.Name = "btn_RemoveBr";
            this.btn_RemoveBr.Size = new System.Drawing.Size(100, 32);
            this.btn_RemoveBr.TabIndex = 3;
            this.btn_RemoveBr.Text = "Xoá danh mục";
            this.btn_RemoveBr.UseVisualStyleBackColor = true;
            this.btn_RemoveBr.Click += new System.EventHandler(this.btn_RemoveBr_Click);
            // 
            // btn_editbr
            // 
            this.btn_editbr.Location = new System.Drawing.Point(324, 294);
            this.btn_editbr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editbr.Name = "btn_editbr";
            this.btn_editbr.Size = new System.Drawing.Size(100, 32);
            this.btn_editbr.TabIndex = 2;
            this.btn_editbr.Text = "Sửa danh muc";
            this.btn_editbr.UseVisualStyleBackColor = true;
            this.btn_editbr.Click += new System.EventHandler(this.btn_editbr_Click);
            // 
            // txb_namebrand
            // 
            this.txb_namebrand.Location = new System.Drawing.Point(158, 63);
            this.txb_namebrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_namebrand.Name = "txb_namebrand";
            this.txb_namebrand.Size = new System.Drawing.Size(178, 22);
            this.txb_namebrand.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên danh mục";
            // 
            // dtgv_brand
            // 
            this.dtgv_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_brand.Location = new System.Drawing.Point(13, 19);
            this.dtgv_brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_brand.Name = "dtgv_brand";
            this.dtgv_brand.RowHeadersWidth = 62;
            this.dtgv_brand.RowTemplate.Height = 28;
            this.dtgv_brand.Size = new System.Drawing.Size(556, 340);
            this.dtgv_brand.TabIndex = 12;
            // 
            // UC_Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panbr);
            this.Controls.Add(this.dtgv_brand);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Brand";
            this.Size = new System.Drawing.Size(1036, 378);
            this.Panbr.ResumeLayout(false);
            this.Panbr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_brand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panbr;
        private System.Windows.Forms.Button btn_AddBr;
        private System.Windows.Forms.TextBox txb_desbr;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Button btn_RemoveBr;
        private System.Windows.Forms.Button btn_editbr;
        private System.Windows.Forms.TextBox txb_namebrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cate;
    }
}
