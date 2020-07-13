using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return ProductDAO.instance; }
            private set { ProductDAO.instance = value; }
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string query = " Select * from Product";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }
            return list;
        }

        public bool InsertProduct(string name, float price, int discount, int warranty, string origin)
        {

            string query = string.Format("INSERT dbo.Product ( namepro , pricepro, discountpro, warrantypro, originpro)VALUES  " +
                                         "( N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')", name, price, discount, warranty, origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(string name, int id, float price, int discount, int warranty, string origin)
        {
            string query = string.Format("UPDATE dbo.Product SET namepro = N'{0}', pricepro = N'{2}', discountpro = N'{3}', " +
                                         " discountpro = N'{4}', originpro = N'{5}' WHERE idpro = {1}", name, id, price, discount, warranty, origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        
        public bool DeleteProductByID(int id)
        {
            string query = string.Format("Delete dbo.Product where IDPro = {0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public Product GetProductByID(int id)
        {
            Product product = null;
            string query = "SELECT*FROM Product where IDPro =" + id;
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                product = new Product(item);
                return product;
            }
            return product;
        }
    }
}
