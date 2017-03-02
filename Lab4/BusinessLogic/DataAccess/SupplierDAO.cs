using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccess
{
    public class SupplierDAO
    {
        public List<Suppliers> getAllSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            string sql = "SELECT * FROM Suppliers";
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            while (reader.Read())
            {
                Suppliers supplier = new Suppliers
                {
                    SupplierId = reader.GetString(0),
                    CompanyName = reader.GetString(1),
                    ContactName = reader.GetString(2),
                    ContactTitle = reader.GetString(3),
                    Address = reader.GetString(4),
                    City = reader.GetString(5),
                    Region = reader.GetString(6),
                    PostalCode = reader.GetString(7),
                    Country = reader.GetString(8),
                    Phone = reader.GetString(9),
                    Fax = reader.GetString(10),
                    HomePage = reader.GetString(11),
                };
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public List<Suppliers> searchByCompanyName(string companyName)
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            string sql = "SELECT * FROM Suppliers WHERE CompanyName LIKE N'%" + companyName + "%'";
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            while (reader.Read())
            {
                Suppliers supplier = new Suppliers
                {
                    SupplierId = reader.GetString(0),
                    CompanyName = reader.GetString(1),
                    ContactName = reader.GetString(2),
                    ContactTitle = reader.GetString(3),
                    Address = reader.GetString(4),
                    City = reader.GetString(5),
                    Region = reader.GetString(6),
                    PostalCode = reader.GetString(7),
                    Country = reader.GetString(8),
                    Phone = reader.GetString(9),
                    Fax = reader.GetString(10),
                    HomePage = reader.GetString(11),
                };
                suppliers.Add(supplier);
            }
            return suppliers;
        }
    }
}
