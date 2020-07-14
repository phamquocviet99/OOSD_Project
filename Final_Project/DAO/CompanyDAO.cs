using Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    class CompanyDAO
    {
        private static CompanyDAO instance;
        public static CompanyDAO Instance
        {
            get { if (instance == null) instance = new CompanyDAO(); return CompanyDAO.instance; }
            private set { CompanyDAO.instance = value; }
        }

        public List<Company> GetListCompany()
        {
            List<Company> list = new List<Company>();
            string query = " Select * from Company";
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Company company = new Company(item);
                list.Add(company);
            }
            return list;
        }

        public bool InsertCompany(string name, string address, string phone)
        {

            string query = string.Format("INSERT dbo.Company ( NameC , addressC, phoneC)VALUES  ( N'{0}', N'{1}', N'{2}')", name, address, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCompany(string name, int id, string address, string phone)
        {
            string query = string.Format("UPDATE dbo.Company SET namec = N'{0}', addressc = N'{2}', phonec = N'{3}' WHERE idc = {1}", name, id, address, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //public bool DeleteCompany(int id)
        //{
        //    string query = string.Format("Delete dbo.Company where IDC = {0}", id);
        //    int result = MyDB.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}
        public bool DeleteCompanyByID(int id)
        {
            string query = string.Format("Delete dbo.Company where IDC = {0}", id);
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
