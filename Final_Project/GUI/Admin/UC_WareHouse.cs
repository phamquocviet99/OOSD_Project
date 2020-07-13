using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.GUI.Admin;
using Final_Project.DAO;
using System.Globalization;

namespace Final_Project.GUI.Admin
{
    public partial class UC_WareHouse : UserControl
    {
        
        public UC_WareHouse()
        {
            InitializeComponent();
        }
        BindingSource listwarehouse= new BindingSource();

        void Load()
        {
            Load();
            dtgvWarehouse.RowTemplate.Height = 25;
            dtgvWarehouse.DataSource = listwarehouse;
        }
        void LoadListWarehouse()
        {
            listwarehouse.DataSource = WarehouseDAO.Instance.GetListWarehouse();
        }
        bool verif()
        {
            if ((txb_Address.Text.Trim() == "")
                        || (txb_Quantity.Text.Trim() == "")
                        
                        )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void dtgvWarehouse_Click(object sender, EventArgs e)
        {
            tbx_id.Text = dtgvWarehouse.CurrentRow.Cells[0].Value.ToString();
            tbx_idpro.Text = dtgvWarehouse.CurrentRow.Cells[1].Value.ToString();
            txb_Address.Text = dtgvWarehouse.CurrentRow.Cells[2].Value.ToString();
            txb_Quantity.Text = dtgvWarehouse.CurrentRow.Cells[3].Value.ToString();
            //txb_Phone.Text = dtgvCustomer.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_id.Text = "";
            tbx_idpro.Text = "";
            txb_Address.Text = "";
            txb_Quantity.Text = "";
        }

        private void btn_AddWarehouse_Click(object sender, EventArgs e)
        {
            string address= txb_Address.Text;
            string quantity =txb_Quantity.Text;
            string id_pro = tbx_idpro.Text;
            tbx_idpro.Text = "1";
            if (verif())
            {
                if (WarehouseDAO.Instance.InsertWarehouse(id_pro, address,quantity))
                {
                    MessageBox.Show("Thêm kho thành công", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Error", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emty Fields", "Add Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_EditWarehouse_Click(object sender, EventArgs e)
        {
            string idwa = tbx_id.Text;
            string id_pro = tbx_idpro.Text;
            string address = txb_Address.Text;
            string quantity = txb_Quantity.Text;
           

            if (verif())
            {
                if (WarehouseDAO.Instance.UpdateWarehouse(idwa,id_pro, address, quantity))
                {
                    MessageBox.Show("Sửa kho thành công", "Sửa kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Sửa kho không thành công", "Sửa kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Emty Fields", "Edit Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_RemoveWarehouse_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbx_id.Text);
            if (WarehouseDAO.Instance.DeleteWarehouse(id))
            {
                MessageBox.Show("Xóa kho thành công", "Xóa kho  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xóa kho không thành công", "Xóa khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        
    }
}
