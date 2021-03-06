﻿namespace Final_Project.GUI
{
    partial class UC_Employee
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
            this.btn_AddEm = new System.Windows.Forms.Button();
            this.btn_RemoveEm = new System.Windows.Forms.Button();
            this.btn_EditEm = new System.Windows.Forms.Button();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.btn_createacc = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.dtpk_Birth = new System.Windows.Forms.DateTimePicker();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_LName = new System.Windows.Forms.TextBox();
            this.txb_FName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvEmp = new System.Windows.Forms.DataGridView();
            this.PanEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddEm
            // 
            this.btn_AddEm.Location = new System.Drawing.Point(250, 294);
            this.btn_AddEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddEm.Name = "btn_AddEm";
            this.btn_AddEm.Size = new System.Drawing.Size(100, 32);
            this.btn_AddEm.TabIndex = 2;
            this.btn_AddEm.Text = "Thêm nhân viên";
            this.btn_AddEm.UseVisualStyleBackColor = true;
            this.btn_AddEm.Click += new System.EventHandler(this.btn_AddEm_Click);
            // 
            // btn_RemoveEm
            // 
            this.btn_RemoveEm.Location = new System.Drawing.Point(137, 294);
            this.btn_RemoveEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveEm.Name = "btn_RemoveEm";
            this.btn_RemoveEm.Size = new System.Drawing.Size(100, 32);
            this.btn_RemoveEm.TabIndex = 3;
            this.btn_RemoveEm.Text = "Xoá nhân viên";
            this.btn_RemoveEm.UseVisualStyleBackColor = true;
            this.btn_RemoveEm.Click += new System.EventHandler(this.btn_RemoveEm_Click);
            // 
            // btn_EditEm
            // 
            this.btn_EditEm.Location = new System.Drawing.Point(18, 301);
            this.btn_EditEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditEm.Name = "btn_EditEm";
            this.btn_EditEm.Size = new System.Drawing.Size(113, 32);
            this.btn_EditEm.TabIndex = 4;
            this.btn_EditEm.Text = "Chỉnh sửa nhân viên";
            this.btn_EditEm.UseVisualStyleBackColor = true;
            this.btn_EditEm.Click += new System.EventHandler(this.btn_EditEm_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.btn_createacc);
            this.PanEmployee.Controls.Add(this.tbx_id);
            this.PanEmployee.Controls.Add(this.txb_Phone);
            this.PanEmployee.Controls.Add(this.btn_EditEm);
            this.PanEmployee.Controls.Add(this.dtpk_Birth);
            this.PanEmployee.Controls.Add(this.btn_RemoveEm);
            this.PanEmployee.Controls.Add(this.txb_Address);
            this.PanEmployee.Controls.Add(this.btn_AddEm);
            this.PanEmployee.Controls.Add(this.txb_LName);
            this.PanEmployee.Controls.Add(this.txb_FName);
            this.PanEmployee.Controls.Add(this.label8);
            this.PanEmployee.Controls.Add(this.rb_Female);
            this.PanEmployee.Controls.Add(this.rb_Male);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label5);
            this.PanEmployee.Controls.Add(this.label6);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Controls.Add(this.label2);
            this.PanEmployee.Location = new System.Drawing.Point(562, 34);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(450, 342);
            this.PanEmployee.TabIndex = 5;
            // 
            // btn_createacc
            // 
            this.btn_createacc.Location = new System.Drawing.Point(355, 288);
            this.btn_createacc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createacc.Name = "btn_createacc";
            this.btn_createacc.Size = new System.Drawing.Size(77, 45);
            this.btn_createacc.TabIndex = 36;
            this.btn_createacc.Text = "Tạo tài khoản";
            this.btn_createacc.UseVisualStyleBackColor = true;
            this.btn_createacc.Click += new System.EventHandler(this.btn_createacc_Click);
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(158, 29);
            this.tbx_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(178, 22);
            this.tbx_id.TabIndex = 35;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Location = new System.Drawing.Point(158, 166);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(178, 22);
            this.txb_Phone.TabIndex = 34;
            // 
            // dtpk_Birth
            // 
            this.dtpk_Birth.Location = new System.Drawing.Point(155, 201);
            this.dtpk_Birth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_Birth.Name = "dtpk_Birth";
            this.dtpk_Birth.Size = new System.Drawing.Size(249, 22);
            this.dtpk_Birth.TabIndex = 33;
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(158, 133);
            this.txb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(178, 22);
            this.txb_Address.TabIndex = 32;
            // 
            // txb_LName
            // 
            this.txb_LName.Location = new System.Drawing.Point(158, 98);
            this.txb_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_LName.Name = "txb_LName";
            this.txb_LName.Size = new System.Drawing.Size(178, 22);
            this.txb_LName.TabIndex = 31;
            // 
            // txb_FName
            // 
            this.txb_FName.Location = new System.Drawing.Point(158, 63);
            this.txb_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_FName.Name = "txb_FName";
            this.txb_FName.Size = new System.Drawing.Size(178, 22);
            this.txb_FName.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Địa chỉ";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(231, 239);
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
            this.rb_Male.Location = new System.Drawing.Point(155, 239);
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
            this.label4.Location = new System.Drawing.Point(29, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 201);
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
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Họ nhân viên";
            // 
            // dtgvEmp
            // 
            this.dtgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmp.Location = new System.Drawing.Point(1, 35);
            this.dtgvEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvEmp.Name = "dtgvEmp";
            this.dtgvEmp.RowHeadersWidth = 62;
            this.dtgvEmp.RowTemplate.Height = 28;
            this.dtgvEmp.Size = new System.Drawing.Size(556, 340);
            this.dtgvEmp.TabIndex = 6;
            this.dtgvEmp.Click += new System.EventHandler(this.dtgvEmp_Click);
            this.dtgvEmp.DoubleClick += new System.EventHandler(this.dtgvEmp_DoubleClick);
            // 
            // UC_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvEmp);
            this.Controls.Add(this.PanEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(1017, 378);
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddEm;
        private System.Windows.Forms.Button btn_RemoveEm;
        private System.Windows.Forms.Button btn_EditEm;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.DataGridView dtgvEmp;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.DateTimePicker dtpk_Birth;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_LName;
        private System.Windows.Forms.TextBox txb_FName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Button btn_createacc;
    }
}
