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

    class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }
        private CustomerDAO(){}
        public bool InsertCustomer(string fname, string lname, DateTime birthday, string gender, string phone)
        {

            string query = string.Format("INSERT  dbo.Customer(FirstN,LastN,Birthday,Gender,Phone)VALUES ( N'{0}', N'{1}', '{2}', N'{3}', {4})", fname, lname, birthday, gender, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public List<Customer> GetListCustomer()
        {
            List<Customer> list = new List<Customer>();
            string query = " Select * from Customer";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }
        public bool DeleteCustomer(int id)
        {
            AccountDAO.Instance.RemoveAccount(id);
            string query = string.Format("DELETE FROM CUSTOMER WHERE idcus ={0}", id);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCustomer(string id, string fname, string lname, DateTime birthday, string gender, string phone)
        {
            string query = string.Format("UPDATE dbo.Customer SET FirstN = N'{1}',LastN = N'{2}', Birthday = '{3}', Gender = '{4}',Phone = N'{5}' WHERE idcus = {0}", id, fname, lname, birthday, gender, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int execCount(string query)
        {
            int count = MyDB.Instance.ExecuteNonQuery(query);
            return count;
        }
        public List<Customer> SearchCustomerbyphone(string phone)
        {
            List<Customer> list = new List<Customer>();

            string query = string.Format("SELECT * FROM dbo.Customer WHERE dbo.fuConvertToUnsign1(namepro) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", phone);

            DataTable data = MyDB.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer cus = new Customer(item);
                list.Add(cus);
            }

            return list;
        }
        
    }
}
