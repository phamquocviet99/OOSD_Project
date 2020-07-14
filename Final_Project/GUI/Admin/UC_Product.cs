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
using System;

namespace Final_Project.GUI.Admin
{
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
            Load();
        }
       
        //BindingSource listpro = new BindingSource();
        new void Load()
        {
            LoadListproduct();
            dtgv_product.RowTemplate.Height = 25;
            //dtgv_product.DataSource = listpro;
            LoadCombox(cb_brand);

        }
        void LoadListproduct()
        {
            
            dtgv_product.DataSource = ProductDAO.Instance.GetListProduct();
        }
        void LoadCombox(ComboBox cb)
        {
            cb.DataSource = BrandDAO.Instance.GetListBrand();
            cb.DisplayMember = "Name";
        }

        private void btn_Addproduct_Click(object sender, System.EventArgs e)
        {
            string name = txb_nameproduct.Text;
            float price = (float)num_Price.Value;
            int discount = Convert.ToInt32(txb_discountproduct.Text);
            int warranty = Convert.ToInt32(txb_warrantyproduct.Text);
            string origin = txb_originproduct.Text;
           
            int idbr = (cb_brand.SelectedItem as Brand).Id;
            if (verif())
            {
                if (ProductDAO.Instance.InsertProduct(idbr,name,price,discount,warranty,origin))
                {
                    MessageBox.Show("Thêm thành công sản phẩm mới", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Editproduct_Click(object sender, System.EventArgs e)
        {
            int id = Convert.ToInt32(tbx_idpro.Text);
            int idbr = Convert.ToInt32(cb_brand.Text);
            string name = txb_nameproduct.Text;
            float price = (float)num_Price.Value;
            int discount = Convert.ToInt32(txb_discountproduct.Text);
            int warranty = Convert.ToInt32(txb_warrantyproduct.Text);
            string origin = txb_originproduct.Text;

            if (verif())
            {
                if (ProductDAO.Instance.UpdateProduct(id,idbr,name,price,discount,warranty,origin))
                {
                    MessageBox.Show("Sửa thành công sản phẩm mới", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm thất bại", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thông tin bị trống", "Sửa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Removeproduct_Click(object sender, System.EventArgs e)
        {
            int id = Convert.ToInt32(tbx_idpro.Text);
            if (ProductDAO.Instance.DeleteProduct(id))
            {
                MessageBox.Show("Xóa thành công sản phẩm mới", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thất bại", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Clear_Click(object sender, System.EventArgs e)
        {
            tbx_idpro.Text = "";
            txb_discountproduct.Text = "";
            txb_nameproduct.Text = "";
            txb_originproduct.Text = "";
            num_Price.Text = "";
            txb_warrantyproduct.Text = "";
            cb_brand.Text = "";
            
        }
        bool verif()
        {
            if ((cb_brand.Text.Trim() == "")
                        || (txb_discountproduct.Text.Trim() == "")
                        || (txb_nameproduct.Text.Trim() == "")
                        || (txb_originproduct.Text.Trim() == "")
                        
                        || (txb_warrantyproduct.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void dtgvproduct_Click(object sender, EventArgs e)
        {
            tbx_idpro.Text = dtgv_product.CurrentRow.Cells[0].Value.ToString();
            cb_brand.Text = dtgv_product.CurrentRow.Cells[1].Value.ToString();
            txb_nameproduct.Text = dtgv_product.CurrentRow.Cells[2].Value.ToString();
            num_Price.Text = dtgv_product.CurrentRow.Cells[3].Value.ToString();
            txb_discountproduct.Text = dtgv_product.CurrentRow.Cells[4].Value.ToString();
            txb_warrantyproduct.Text = dtgv_product.CurrentRow.Cells[5].Value.ToString();
            txb_originproduct.Text = dtgv_product.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
