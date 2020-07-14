namespace Final_Project.GUI.Admin
{
    partial class UC_WareHouse
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
            this.dtgvWarehouse = new System.Windows.Forms.DataGridView();
            this.PanEmployee = new System.Windows.Forms.Panel();
            this.cb_pro = new System.Windows.Forms.ComboBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.txb_Quantity = new System.Windows.Forms.TextBox();
            this.btn_EditWarehouse = new System.Windows.Forms.Button();
            this.btn_RemoveWarehouse = new System.Windows.Forms.Button();
            this.btn_AddWarehouse = new System.Windows.Forms.Button();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarehouse)).BeginInit();
            this.PanEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvWarehouse
            // 
            this.dtgvWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvWarehouse.Location = new System.Drawing.Point(3, 14);
            this.dtgvWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvWarehouse.Name = "dtgvWarehouse";
            this.dtgvWarehouse.RowHeadersWidth = 62;
            this.dtgvWarehouse.RowTemplate.Height = 28;
            this.dtgvWarehouse.Size = new System.Drawing.Size(556, 340);
            this.dtgvWarehouse.TabIndex = 8;
            this.dtgvWarehouse.Click += new System.EventHandler(this.dtgvWarehouse_Click);
            // 
            // PanEmployee
            // 
            this.PanEmployee.Controls.Add(this.cb_pro);
            this.PanEmployee.Controls.Add(this.btn_Clear);
            this.PanEmployee.Controls.Add(this.tbx_id);
            this.PanEmployee.Controls.Add(this.txb_Quantity);
            this.PanEmployee.Controls.Add(this.btn_EditWarehouse);
            this.PanEmployee.Controls.Add(this.btn_RemoveWarehouse);
            this.PanEmployee.Controls.Add(this.btn_AddWarehouse);
            this.PanEmployee.Controls.Add(this.txb_Address);
            this.PanEmployee.Controls.Add(this.label4);
            this.PanEmployee.Controls.Add(this.label3);
            this.PanEmployee.Location = new System.Drawing.Point(588, 14);
            this.PanEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanEmployee.Name = "PanEmployee";
            this.PanEmployee.Size = new System.Drawing.Size(450, 334);
            this.PanEmployee.TabIndex = 9;
            // 
            // cb_pro
            // 
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.Location = new System.Drawing.Point(155, 60);
            this.cb_pro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(181, 24);
            this.cb_pro.TabIndex = 37;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(15, 182);
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
            this.tbx_id.ReadOnly = true;
            this.tbx_id.Size = new System.Drawing.Size(178, 22);
            this.tbx_id.TabIndex = 35;
            // 
            // txb_Quantity
            // 
            this.txb_Quantity.Location = new System.Drawing.Point(155, 134);
            this.txb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Quantity.Name = "txb_Quantity";
            this.txb_Quantity.Size = new System.Drawing.Size(178, 22);
            this.txb_Quantity.TabIndex = 34;
            // 
            // btn_EditWarehouse
            // 
            this.btn_EditWarehouse.Location = new System.Drawing.Point(15, 237);
            this.btn_EditWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EditWarehouse.Name = "btn_EditWarehouse";
            this.btn_EditWarehouse.Size = new System.Drawing.Size(113, 32);
            this.btn_EditWarehouse.TabIndex = 4;
            this.btn_EditWarehouse.Text = "Chỉnh sửa";
            this.btn_EditWarehouse.UseVisualStyleBackColor = true;
            this.btn_EditWarehouse.Click += new System.EventHandler(this.btn_EditWarehouse_Click);
            // 
            // btn_RemoveWarehouse
            // 
            this.btn_RemoveWarehouse.Location = new System.Drawing.Point(155, 237);
            this.btn_RemoveWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RemoveWarehouse.Name = "btn_RemoveWarehouse";
            this.btn_RemoveWarehouse.Size = new System.Drawing.Size(100, 32);
            this.btn_RemoveWarehouse.TabIndex = 3;
            this.btn_RemoveWarehouse.Text = "Xoá";
            this.btn_RemoveWarehouse.UseVisualStyleBackColor = true;
            this.btn_RemoveWarehouse.Click += new System.EventHandler(this.btn_RemoveWarehouse_Click);
            // 
            // btn_AddWarehouse
            // 
            this.btn_AddWarehouse.Location = new System.Drawing.Point(281, 237);
            this.btn_AddWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddWarehouse.Name = "btn_AddWarehouse";
            this.btn_AddWarehouse.Size = new System.Drawing.Size(100, 32);
            this.btn_AddWarehouse.TabIndex = 2;
            this.btn_AddWarehouse.Text = "Thêm ";
            this.btn_AddWarehouse.UseVisualStyleBackColor = true;
            this.btn_AddWarehouse.Click += new System.EventHandler(this.btn_AddWarehouse_Click);
            // 
            // txb_Address
            // 
            this.txb_Address.Location = new System.Drawing.Point(155, 98);
            this.txb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(178, 22);
            this.txb_Address.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Số lượng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ ";
            // 
            // UC_WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanEmployee);
            this.Controls.Add(this.dtgvWarehouse);
            this.Name = "UC_WareHouse";
            this.Size = new System.Drawing.Size(1106, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvWarehouse)).EndInit();
            this.PanEmployee.ResumeLayout(false);
            this.PanEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvWarehouse;
        private System.Windows.Forms.Panel PanEmployee;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.TextBox txb_Quantity;
        private System.Windows.Forms.Button btn_EditWarehouse;
        private System.Windows.Forms.Button btn_RemoveWarehouse;
        private System.Windows.Forms.Button btn_AddWarehouse;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pro;
    }
}
