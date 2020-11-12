using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using SSETechnicalTest.Models;
using System.Data.SqlClient;

namespace SSETechnicalTest.Data
{
    public class DataAccess
    {
        // get all categories + mark features
        public List<Category> GetCategories()
        {
            using (IDbConnection connect = new SqlConnection(Helper.ConnectionString("DBAccess")))
            {
                var categories = connect.Query<Category>("Category_GetCategories").ToList();
                return categories;
            }
        }

        // display a list of the selected category products
        public List<Product> GetProductsByCategoryId(string categoryId)
        {
            using (IDbConnection connect = new SqlConnection(Helper.ConnectionString("DBAccess")))
            {
                var products =  connect.Query<Product>("Product_GetProductsByCategoryId @CategoryId", new { CategoryId = categoryId }).ToList();
                return products;
            }
        }
    }
}
