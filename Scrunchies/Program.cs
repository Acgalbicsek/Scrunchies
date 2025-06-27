using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Scrunchies.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration.Json;




namespace Scrunchies
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = config.GetConnectionString("ScrunchieDB");


            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
              
            }


            Product batmanScrunchie = new Product
            {
                Name = "Batman",
                StockQuantity = 3
            };

            DatabaseHelper.AddProduct(batmanScrunchie);

            Product helloKittyScrunchie = new Product
            {
                Name = "Hello Kitty",
                StockQuantity = 8
            };
            DatabaseHelper.AddProduct(helloKittyScrunchie);


            Product blackSWScrunchie = new Product
            {
                Name = "Black SouthWest",
                StockQuantity = 5
            };
            DatabaseHelper.AddProduct(blackSWScrunchie);

            Product blueberryScrunchie = new Product
            {
                Name = "Blueberry",
                StockQuantity = 9
            };
            DatabaseHelper.AddProduct(blueberryScrunchie);

            Product blackMoonScrunchie = new Product
            {
                Name = "Black Crescent Moon",
                StockQuantity = 5
            };
            DatabaseHelper.AddProduct(blackMoonScrunchie);

            Product birthdayPokemonScrunchie = new Product
            {
                Name = "Birthday Pokemon",
                StockQuantity = 2
            };
            DatabaseHelper.AddProduct(birthdayPokemonScrunchie);

            Product blackPokemonScrunchie = new Product
            {
                Name = "Black Pokemon",
                 StockQuantity = 8
            };
            DatabaseHelper.AddProduct(blackPokemonScrunchie);

            Product salmonScrunchie = new Product
            {
                Name = "Salmon",
                StockQuantity = 9
            };

            DatabaseHelper.AddProduct(salmonScrunchie);

            Product walrusScrunchie = new Product
            {
                Name = "Walrus",
                StockQuantity = 6
            };

            DatabaseHelper.AddProduct(walrusScrunchie);


            Product butterflyScrunchie = new Product
            {
                Name = "Butterfly",
                StockQuantity = 5
            };

            DatabaseHelper.AddProduct(butterflyScrunchie);

            Product majesticHorseScrunchie = new Product
            {
                Name = "Majestic Horse",
                StockQuantity = 4
            };

            DatabaseHelper.AddProduct(majesticHorseScrunchie);

            Product sherbetScrunchie = new Product
            {
                Name = "Sherbet",
                StockQuantity = 8
            };

            Product brownNativeScrunchie = new Product
            {
                Name = "Brown Native",
                StockQuantity = 5
            };

            DatabaseHelper.AddProduct(brownNativeScrunchie);


            Product fireweedScrunchie = new Product
            {
                Name = "Fireweed",
                StockQuantity = 10
            };

            DatabaseHelper.AddProduct(fireweedScrunchie);

            Product underTheSeaScrunchie = new Product
            {
                Name = "Under The Sea",
                StockQuantity = 2
            };

            DatabaseHelper.AddProduct(underTheSeaScrunchie);


            Product bohoChicScruchie = new Product
            {
                Name = "Boho Chic",
                StockQuantity = 7
            };

            DatabaseHelper.AddProduct(bohoChicScruchie);

            Product brownPlaidScrunchie = new Product
            {
                Name = "Brown Plaid",
                StockQuantity = 8
            };

            DatabaseHelper.AddProduct(brownPlaidScrunchie);

            Product milkAndCookiesScrunchie = new Product
            {
                Name = "Milk and Cookies",
                StockQuantity = 9
            };

            DatabaseHelper.AddProduct(milkAndCookiesScrunchie);

            Product blueBeesScrunchie = new Product
            {
                Name = "Blue Bees",
                StockQuantity = 4
            };

            DatabaseHelper.AddProduct(blueBeesScrunchie);

            Product blackCherryScrunchie = new Product
            {
                Name = "Black Cherry",
                StockQuantity = 4
            };

            DatabaseHelper.AddProduct(blackCherryScrunchie);

            Product parkDaysScrunchie = new Product
            {
                Name = "Park Days",
                StockQuantity = 4
            };

            DatabaseHelper.AddProduct(parkDaysScrunchie);

            Product miscScrunchie = new Product
            {
                Name = "Misc",
                StockQuantity = 7
            };

            DatabaseHelper.AddProduct(miscScrunchie);



            Console.WriteLine($"Retrieving your scrunchie inventory...");

            var products = DatabaseHelper.GetAllProducts;

            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.IDProduct}, Name: {p.Name}, Stock: {p.StockQuantity}");
            }

            Console.WriteLine($"Inventory loaded successfully.");




            //var salesSummary = DatabaseHelper.GetSalesByProduct();

            //foreach (var item in salesSummary)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Total Sold: {item.TotalQuantitySold}");
            //}

        }

    }

        
    
}