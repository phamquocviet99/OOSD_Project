namespace Final_Project.GUI.Admin
{
    partial class UC_Customer
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
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.btn_EditCustomer = new System.Windows.Forms.Button();
            this.dtpk_Birth = new System.Windows.Forms.DateTimePicker();
            this.btn_RemoveCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.txb_LName = new System.Windows.Forms.TextBox();
            this.txb_FName = new System.Windows.Forms.TextBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(3, 13);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 62;
            this.dtgvCustomer.RowTemplate.Height = 28;
            this.dtgvCustomer.Size = new System.Drawing.Size(556, 340);
            this.dtgvCustomer.TabIndex = 7;
            this.dtgvCustomer.Click += new System.EventHandler(this.dtgvCustomer_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_Clear);
            this.PanEmployee.Controls.Add(this.tbx_id);
            this.PanEmployee.Controls.Add(this.txb_Phone);
            this.PanEmployee.Controls.Add(this.btn_EditCustomer);
            this.PanEmployee.Controls.Add(this.dtpk_Birth);
            this.PanEmployee.Controls.Add(this.btn_RemoveCustomer);
            this.PanEmployee.Controls.Add(this.btn_AddCustomer);
            this.PanEmployee.Controls.Add(this.txb_LName);
            this.PanEmployee.Controls.Add(this.txb_FName);
            this.PanEmployee.Controls.Add(this.rb_Female);
            this.PanEmployee.Controls.Add(this.rb_Male);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label5);
            this.PanEmployee.Controls.Add(this.label6);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(580, 13);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(450, 342);
            this.PanEmployee.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(28, 301);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 32);
            this.btn_Clear.TabIndex = 36;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(155, 25);
            this.tbx_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(178, 22);
            this.tbx_id.TabIndex = 35;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(155, 134);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(178, 22);
            this.txb_Phone.TabIndex = 34;
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.Location = new System.Drawing.Point(27, 265);
            this.btn_EditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Size = new System.Drawing.Size(113, 32);
            this.btn_EditCustomer.TabIndex = 4;
            this.btn_EditCustomer.Text = "Chỉnh sửa khách hàng";
            this.btn_EditCustomer.UseVisualStyleBackColor = true;
            this.btn_EditCustomer.Click += new System.EventHandler(this.btn_EditCustomer_Click);
            // 
            // dtpk_Birth
            // 
            this.dtpk_Birth.Location = new System.Drawing.Point(155, 174);
            this.dtpk_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_Birth.Name = "dtpk_Birth";
            this.dtpk_Birth.Size = new System.Drawing.Size(249, 22);
            this.dtpk_Birth.TabIndex = 33;
            // 
            // btn_RemoveCustomer
            // 
            this.btn_RemoveCustomer.Location = new System.Drawing.Point(155, 265);
            this.btn_RemoveCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveCustomer.Name = "btn_RemoveCustomer";
            this.btn_RemoveCustomer.Size = new System.Drawing.Size(100, 32);
            this.btn_RemoveCustomer.TabIndex = 3;
            this.btn_RemoveCustomer.Text = "Xoá khách hàng";
            this.btn_RemoveCustomer.UseVisualStyleBackColor = true;
            this.btn_RemoveCustomer.Click += new System.EventHandler(this.btn_RemoveCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Location = new System.Drawing.Point(272, 265);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(100, 32);
            this.btn_AddCustomer.TabIndex = 2;
            this.btn_AddCustomer.Text = "Thêm khách hàng";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // txb_LName
            // 
            this.txb_LName.Location = new System.Drawing.Point(155, 98);
            this.txb_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_LName.Name = "txb_LName";
            this.txb_LName.Size = new System.Drawing.Size(178, 22);
            this.txb_LName.TabIndex = 31;
            // 
            // txb_FName
            // 
            this.txb_FName.Location = new System.Drawing.Point(155, 63);
            this.txb_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_FName.Name = "txb_FName";
            this.txb_FName.Size = new System.Drawing.Size(178, 22);
            this.txb_FName.TabIndex = 30;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(240, 221);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(47, 21);
            this.rb_Female.TabIndex = 27;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(155, 221);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(58, 21);
            this.rb_Male.TabIndex = 26;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày sinh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ khách hàng";
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgvCustomer);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1093, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Button btn_EditCustomer;
        private System.Windows.Forms.DateTimePicker dtpk_Birth;
        private System.Windows.Forms.Button btn_RemoveCustomer;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.TextBox txb_LName;
        private System.Windows.Forms.TextBox txb_FName;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
    }
}
