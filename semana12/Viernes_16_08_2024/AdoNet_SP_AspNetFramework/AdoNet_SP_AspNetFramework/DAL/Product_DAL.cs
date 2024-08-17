using AdoNet_SP_AspNetFramework.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoNet_SP_AspNetFramework.DAL
{
    public class Product_DAL
    {
        string connectionString = 
            ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        //GetAllProducts
        public List<ProductModels> GetAllProducts()
        {
            List<ProductModels> listProducts = new List<ProductModels>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_GetAllProducts";

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dtProducts = new DataTable();

                connection.Open();
                adapter.Fill(dtProducts);
                connection.Close();

                foreach(DataRow item in dtProducts.Rows)
                {
                    ProductModels product = new ProductModels();
                    product.ProductId = Convert.ToInt32(item["ProductId"]);
                    product.ProductName = item["Product"].ToString();
                    product.Price = Convert.ToDecimal(item["Price"]);
                    product.Quantity = Convert.ToInt32(item["Quantity"]);
                    product.Remarks = item["Remarks"].ToString();

                    listProducts.Add(product);
                }
            }
            return listProducts;
        }
    }
}