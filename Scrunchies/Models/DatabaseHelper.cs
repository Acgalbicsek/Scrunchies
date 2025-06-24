using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrunchies.Models
{
    public class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=ScrunchieDB;Uid=root;Pwd=password;";

        public static void AddProduct(Product product)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Product (Name, Quantity) 
                         VALUES (@Name, @Quantity)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Product> GetAllProducts
        {
            get
            {
                var products = new List<Product>();
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Product";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                IDProduct = reader.GetInt32("IDProduct"),
                                Name = reader.GetString("Name"),
                                Quantity = reader.GetInt32("Quantity"),
                                StockQuantity = reader.GetInt32("StockQuantity")
                            });
                        }
                    }

                    return products;
                }

            }
        }    
                


        public static void AddSale(Sales sale)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Sales (ProductID, QuantitySold, DateSold)
                         VALUES (@ProductID, @QuantitySold, @DateSold)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", sale.IdNumber);
                    cmd.Parameters.AddWithValue("@QuantitySold", sale.QuantitySold);
                    cmd.Parameters.AddWithValue("@DateSold", sale.DateSold);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Sales> GetSalesByDate(DateTime date)
        {
            
            return new List<Sales>();
        }

        

    }

}

