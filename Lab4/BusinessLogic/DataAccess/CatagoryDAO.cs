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
    public class CatagoryDAO
    {
        public List<Catagories> getAllCatagories()
        {
            List<Catagories> catagories = new List<Catagories>();
            string sql = "SELECT * FROM Catagories";
            SqlDataReader reader = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.Text);
            while (reader.Read())
            {
                Catagories catagorie = new Catagories
                {
                    CatagoryId = reader.GetString(0),
                    CatagoryName = reader.GetString(1),
                    Description = reader.GetString(2),
                    Picture = reader.GetString(3),
                };
                catagories.Add(catagorie);
            }
            return catagories;
        }
    }
}
