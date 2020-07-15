using Final_Project.DAO;
using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Project.GUI.Admin
{
    public partial class Saler : Form
    {
        public Saler()
        {
            InitializeComponent();
        }
        List<Category> listCategory = new List<Category>();
        List<Brand> listBrand = new List<Brand>();
        List<Product> listProduct = new List<Product>();
        private void Saler_Load(object sender, EventArgs e)
        {
            cb_Sort.Items.Add("Mới nhất");
            cb_Sort.Items.Add("Cũ nhất");
            cb_Sort.Items.Add("Giá cao");
            cb_Sort.Items.Add("Giá thấp");
            load();
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load()
        {
            LoadCategogy();
            dtgv_product.DataSource = listProduct;
        }
        void LoadCategogy()
        {
            listCategory = CategoryDAO.Instance.GetListCategory();
            cb_Category.DataSource = listCategory;
            cb_Category.DisplayMember = "Name";
        }
        void LoadBrandListByCategory(int id)
        {
            listBrand = BrandDAO.Instance.GetBrandByCategoryID(id);
            cb_Brand.DataSource = listBrand;
            cb_Brand.DisplayMember = "Name";
        }
        void LoadProductListBybrand(int id)
        {
            listProduct = ProductDAO.Instance.GetProductByBrandID(id);
            dtgv_product.DataSource = listProduct;
            
        }
        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadBrandListByCategory(id);
        }

        private void pb_search_Click(object sender, EventArgs e)
        {
            listProduct = ProductDAO.Instance.SearchProductname(txb_search.Text);
            load();
        }

        private void cb_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Brand selected = cb.SelectedItem as Brand;
            id = selected.Id;
            LoadProductListBybrand(id);
        }

        private void lb_createcustomer_Click(object sender, EventArgs e)
        {
            Create_Cus_for_Saler create_Cus_For_Saler = new Create_Cus_for_Saler();
            create_Cus_For_Saler.Show(this);
        }

        private void pb_seachphonecus_Click(object sender, EventArgs e)
        {

        }
    }
}
