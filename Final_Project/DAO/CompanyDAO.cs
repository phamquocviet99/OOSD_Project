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

            string query = string.Format("INSERT dbo.Company ( namecom , address, phone)VALUES  ( N'{0}', N'{1}', N'{2}')", name, address, phone);
            int result = MyDB.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCompany(string name, int id, string address, string phone)
        {
            string query = string.Format("UPDATE dbo.Company SET namecom = N'{0}', address = N'{2}', phone = N'{3}' WHERE idcate = {1}", name, id, address, phone);
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
        public Company GetCompanyByID(int id)
        {
            Company company = null;
            string query = "SELECT*FROM Company where IDC=" + id;
            DataTable data = MyDB.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                company = new Company(item);
                return company;
            }
            return company;
        }
    }
}
