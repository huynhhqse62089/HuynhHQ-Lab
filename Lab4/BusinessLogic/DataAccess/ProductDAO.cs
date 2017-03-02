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
    public class ProductDAO
    {
        public List<Products> getAllProducts()
        {
            List<Products> products = new List<Products>();
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            while (reader.Read())
            {
                Products product = new Products
                {
                    ProductId = reader.GetString(0),
                    ProductName = reader.GetString(1),
                    SupplierId = reader.GetString(2),
                    CatagoryId = reader.GetString(3),
                    QuantityPerUnit = reader.GetInt32(4),
                    UnitPrice = reader.GetFloat(5),
                    UnitsInStock = reader.GetInt32(6),
                    UnitsInOrder = reader.GetInt32(7),
                    ReorderLevel = reader.GetInt32(8),
                    Discontinued = reader.GetBoolean(9),
                };
                products.Add(product);
            }
            return products;
        }


        public List<Products> searchByName(string productName)
        {
            List<Products> products = new List<Products>();
            string sql = "SELECT * FROM Products WHERE ProductName LIKE N'%" + productName + "%'";
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            while (reader.Read())
            {
                Products product = new Products
                {
                    ProductId = reader.GetString(0),
                    ProductName = reader.GetString(1),
                    SupplierId = reader.GetString(2),
                    CatagoryId = reader.GetString(3),
                    QuantityPerUnit = reader.GetInt32(4),
                    UnitPrice = reader.GetFloat(5),
                    UnitsInStock = reader.GetInt32(6),
                    UnitsInOrder = reader.GetInt32(7),
                    ReorderLevel = reader.GetInt32(8),
                    Discontinued = reader.GetBoolean(9),
                };
                products.Add(product);
            }
            return products;
        }

    }
}
