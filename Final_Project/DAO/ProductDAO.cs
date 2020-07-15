using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        private ProductDAO() { }
        public bool InsertProduct(int idbr,string name,float price,int discount,int warranty,string origin)
        {

            string query = string.Format("INSERT  dbo.Product(IDBR,NamePro,PricePro,DiscountPro,Warranty,Origin)VALUES ( N'{0}', N'{1}', '{2}', N'{3}', {4}, N'{5}')", idbr,name,price,discount,warranty,origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();
            string query = " Select * from Product";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product pro = new Product(item);
                list.Add(pro);
            }
            return list;
        }
        public bool DeleteProduct(int id)
        {
            string query = string.Format("DELETE FROM Product WHERE IDPro ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateProduct(int id,int idbr, string name, float price, int discount, int warranty, string origin)
        {
            string query = string.Format("UPDATE dbo.Product SET IDBr={1},NamePro=N'{2}',PricePro={3},DiscountPro={4},Warranty={5},Origin=N'{6}' WHERE IDPro = {0}", id,idbr,name,price,discount,warranty,origin);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }
        public List<Product> SearchProductname(string name)
        {
            List<Product> list = new List<Product>();

            string query = string.Format("SELECT * FROM dbo.Product WHERE dbo.fuConvertToUnsign1(namepro) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }
        public List<Product> GetProductByBrandID(int id)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where IDbr= " + id;

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product product = new Product(item);
                list.Add(product);
            }

            return list;
        }
    }
}
