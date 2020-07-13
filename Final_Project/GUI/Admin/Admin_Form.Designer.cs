namespace Final_Project.GUI
{
    partial class Admin_Form
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
            this.btn_Em = new System.Windows.Forms.Button();
            this.PanAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_brand = new System.Windows.Forms.Button();
            this.btn_Category = new System.Windows.Forms.Button();
            this.btn_Warehouse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Em
            // 
            this.btn_Em.Location = new System.Drawing.Point(10, 27);
            this.btn_Em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Em.Name = "btn_Em";
            this.btn_Em.Size = new System.Drawing.Size(107, 36);
            this.btn_Em.TabIndex = 0;
            this.btn_Em.Text = "Nhân Viên";
            this.btn_Em.UseVisualStyleBackColor = true;
            this.btn_Em.Click += new System.EventHandler(this.btn_Em_Click);
            // 
            // PanAdmin
            // 
            this.PanAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanAdmin.Location = new System.Drawing.Point(148, 29);
            this.PanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanAdmin.Name = "PanAdmin";
            this.PanAdmin.Size = new System.Drawing.Size(1291, 378);
            this.PanAdmin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Warehouse);
            this.panel2.Controls.Add(this.btn_Customer);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_brand);
            this.panel2.Controls.Add(this.btn_Category);
            this.panel2.Controls.Add(this.btn_Em);
            this.panel2.Location = new System.Drawing.Point(4, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 378);
            this.panel2.TabIndex = 2;
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(10, 243);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(107, 36);
            this.btn_Customer.TabIndex = 4;
            this.btn_Customer.Text = "Khách hàng";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tài khoản nhân viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_brand
            // 
            this.btn_brand.Location = new System.Drawing.Point(10, 137);
            this.btn_brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_brand.Name = "btn_brand";
            this.btn_brand.Size = new System.Drawing.Size(107, 36);
            this.btn_brand.TabIndex = 2;
            this.btn_brand.Text = "Brand";
            this.btn_brand.UseVisualStyleBackColor = true;
            this.btn_brand.Click += new System.EventHandler(this.btn_brand_Click);
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(10, 82);
            this.btn_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(107, 36);
            this.btn_Category.TabIndex = 1;
            this.btn_Category.Text = "Danh mục";
            this.btn_Category.UseVisualStyleBackColor = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Warehouse
            // 
            this.btn_Warehouse.Location = new System.Drawing.Point(8, 293);
            this.btn_Warehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Warehouse.Name = "btn_Warehouse";
            this.btn_Warehouse.Size = new System.Drawing.Size(107, 36);
            this.btn_Warehouse.TabIndex = 5;
            this.btn_Warehouse.Text = "Kho hàng";
            this.btn_Warehouse.UseVisualStyleBackColor = true;
            this.btn_Warehouse.Click += new System.EventHandler(this.btn_Warehouse_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanAdmin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Em;
        private System.Windows.Forms.Panel PanAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_brand;
        private System.Windows.Forms.Button btn_Category;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Warehouse;
    }
}