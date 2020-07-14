using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Product
    {
        public Product(int id,int idbr,string name,float price,int discount,int warranty,string origin)
        {
            this.Id = id;
            this.Idbr = idbr;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Warranty = warranty;
            this.Origin = origin;
        }
        public Product(DataRow row)
        {
            this.Id = (int)row["IDPro"];
            this.Idbr = (int)row["IDBr"];
            this.Name = row["NamePro"].ToString();
            this.Price =  (float)Convert.ToDouble(row["PricePro"].ToString());
            this.Discount = (int)row["DiscountPro"];
            this.Warranty = (int)row["Warranty"];
            this.Origin = row["Origin"].ToString();

        }

        private int id;
        private int idbr;
        private string name;
        private float price;
        private int discount;
        private int warranty;
        private string origin;

        public int Id { get => id; set => id = value; }
        public int Idbr { get => idbr; set => idbr = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Warranty { get => warranty; set => warranty = value; }
        public string Origin { get => origin; set => origin = value; }
    }
}
