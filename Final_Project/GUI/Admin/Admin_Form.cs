﻿using Final_Project.DTO;
using Final_Project.GUI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.GUI
{
    public partial class Admin_Form : Form
    {
        //private Account loginAccount;

        //public Account LoginAccount
        //{
        //    get { return loginAccount; }
        //    set
        //    {
        //        loginAccount = value;
        //        Changeaccount(loginAccount.Pos);
        //    }
        //}

        public Admin_Form()
        {
            InitializeComponent();
        }
        void Changeaccount(int type)
        {
            
        }
        private void btn_Em_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Employee uc = new UC_Employee();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Category uc = new UC_Category();
            //uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_brand_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Brand uc = new UC_Brand();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Customer uc = new UC_Customer();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_WareHouse uc = new UC_WareHouse();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Product uc = new UC_Product();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Company uc = new UC_Company();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            btn_Em.FlatAppearance.BorderSize = 0;
            btn_Product.FlatAppearance.BorderSize = 0;
            btn_Warehouse.FlatAppearance.BorderSize = 0;
            btn_Customer.FlatAppearance.BorderSize = 0;
            btn_Company.FlatAppearance.BorderSize = 0;
            btn_brand.FlatAppearance.BorderSize = 0;
          
            btn_Em.FlatAppearance.BorderSize = 0;
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            PanAdmin.Controls.Clear();
            UC_Account uc = new UC_Account();
            uc.Dock = DockStyle.Fill;
            PanAdmin.Controls.Add(uc);
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
