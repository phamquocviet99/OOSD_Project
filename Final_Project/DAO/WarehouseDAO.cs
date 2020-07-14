using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.DAO;
using Final_Project.DTO;


namespace Final_Project.DAO
{
    class WarehouseDAO
    {
        private static WarehouseDAO instance;
        public static WarehouseDAO Instance
        {
            get { if (instance == null) instance = new WarehouseDAO(); return WarehouseDAO.instance; }
            private set { WarehouseDAO.instance = value; }
        }
        private WarehouseDAO() { }
        public bool InsertWarehouse(int id_pro, string address,int quantity)
        {

            string query = string.Format("INSERT dbo.Warehouse(IDPRO,AddressWa,Quantity)VALUES ( N'{0}', N'{1}',N'{2}')",id_pro, address,quantity);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Warehouse> GetListWarehouse()
        {
            List<Warehouse> list = new List<Warehouse>();
            string query = " Select * from Warehouse";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Warehouse warehouse = new Warehouse(item);
                list.Add(warehouse);
            }
            return list;
        }
        public bool DeleteWarehouse(int id)
        {
            AccountDAO.Instance.RemoveAccount(id);
            string query = string.Format("DELETE FROM WAREHOUSE WHERE idwa ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateWarehouse(int idwa,int id_pro, string address,int quantity)
        {
            string query = string.Format("UPDATE dbo.Warehouse SET Idpro={1}, AddressWa = N'{2}',Quantity = {3} WHERE idwa = {0}",idwa, id_pro,address,quantity);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }
    }
}
