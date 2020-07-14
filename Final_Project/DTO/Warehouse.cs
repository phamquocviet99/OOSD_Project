﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DTO
{
    class Warehouse
    {
        public Warehouse(int id,int idpro,string address,int quantity)
        {
            this.Id = id;
            this.Idpro = idpro;
            this.Address = address;
            this.Quantity = quantity;
        }
        public Warehouse(DataRow row )
        {
            this.Id = (int)row["IDWa"];
            this.Idpro = (int)row["IDPro"];
            this.Address = row["AddressWa"].ToString();
            this.Quantity = (int)row["Quantity"];
        }

        private int id;
        private int idpro;
        private string address;
        private int quantity;

        public int Id { get => id; set => id = value; }
        public int Idpro { get => idpro; set => idpro = value; }
        public string Address { get => address; set => address = value; }
        public  int Quantity { get => quantity; set => quantity = value; }
    }
}
