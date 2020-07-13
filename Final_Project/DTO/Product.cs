using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Product
    {
        

        public Product(int id, string name, float price, int discount, int warranty, string origin, int idbrand)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Discount = discount;
            this.Warranty = warranty;
            this.Origin = origin;
            this.IdBr = idbrand;
        }

        public Product(DataRow row)
        {
            this.Id = (int)row["IDPro"];
            this.Name = row["NamePro"].ToString();
            this.Price = (float)row["PricePro"];
            this.Discount = (int)row["DiscountPro"];
            this.Warranty = (int)row["Warranty"];
            this.Origin = row["Origin"].ToString();
            this.IdBr = (int)row["IDBr"];
        }

        private int id;
        private string name;
        private float price;
        private int discount;
        private int warranty;
        private string origin;
        private int idBr;


        public int Id { get => Id; set => Id = value; }
        public string Name { get => Name; set => Name = value; }
        public float Price { get => Price; set => Price = value; }
        public int Discount { get => Discount; set => Discount = value; }
        public int Warranty { get => Warranty; set => Warranty = value; }
        public string Origin { get => Origin; set => Origin = value; }
        public int IdBr { get => IdBr; set => IdBr = value; }
    }
}
