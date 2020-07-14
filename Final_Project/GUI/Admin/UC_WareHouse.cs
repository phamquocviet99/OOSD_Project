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
using Final_Project.DTO;

using System.Globalization;

namespace Final_Project.GUI.Admin
{
    public partial class UC_WareHouse : UserControl
    {
        
        public UC_WareHouse()
        {
            InitializeComponent();
            Load();
        }
        //BindingSource listwarehouse= new BindingSource();

        new void Load()
        {
            LoadListWarehouse();
            dtgvWarehouse.RowTemplate.Height = 25;
            LoadCombox(cb_pro);
        }
        void LoadListWarehouse()
        {
            dtgvWarehouse.DataSource = WarehouseDAO.Instance.GetListWarehouse();
        }
        void LoadCombox(ComboBox cb)
        {
            cb.DataSource = ProductDAO.Instance.GetListProduct();
            cb.DisplayMember = "Name";
        }
        bool verif()
        {
            if ((txb_Address.Text.Trim() == "")
                        || (txb_Quantity.Text.Trim() == ""
                        )
                        
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
            cb_pro.Text = dtgvWarehouse.CurrentRow.Cells[1].Value.ToString();
            txb_Address.Text = dtgvWarehouse.CurrentRow.Cells[2].Value.ToString();
            txb_Quantity.Text = dtgvWarehouse.CurrentRow.Cells[3].Value.ToString();
            //txb_Phone.Text = dtgvCustomer.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_id.Text = "";
            cb_pro.Text = "";
            txb_Address.Text = "";
            txb_Quantity.Text = "";
        }

        private void btn_AddWarehouse_Click(object sender, EventArgs e)
        {
            string address= txb_Address.Text;
            int quantity = Convert.ToInt32(txb_Quantity.Text);
            int id_pro = (cb_pro.SelectedItem as Product).Id;
            if (verif())
            {
                if (WarehouseDAO.Instance.InsertWarehouse(id_pro, address,quantity))
                {
                    MessageBox.Show("Thêm kho thành công", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Thêm kho thất bại", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_EditWarehouse_Click(object sender, EventArgs e)
        {
            
           
            if (tbx_id.Text == "")
            {
                MessageBox.Show("Chọn thông báo cần sửa");
            }
            else
            {
                int idwa = Convert.ToInt32(tbx_id.Text);
                int id_pro = (cb_pro.SelectedItem as Product).Id;
                string address = txb_Address.Text;
                int quantity = Convert.ToInt32(txb_Quantity.Text);
                if (verif())
                {
                    if (WarehouseDAO.Instance.UpdateWarehouse(idwa, id_pro, address, quantity))
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
                    MessageBox.Show("Thông tin bị trống ", "Sửa nhà kho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_RemoveWarehouse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbx_id.Text);
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
