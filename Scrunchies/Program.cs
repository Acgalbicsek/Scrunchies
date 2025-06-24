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
                Quantity = 3
            };

            DatabaseHelper.AddProduct(batmanScrunchie);

            Product helloKittyScrunchie = new Product
            {
                Name = "Hello Kitty",
                Quantity = 8
            };
            DatabaseHelper.AddProduct(helloKittyScrunchie);


            Product blackSWScrunchie = new Product
            {
                Name = "Black SouthWest",
                Quantity = 5
            };
            DatabaseHelper.AddProduct(blackSWScrunchie);

            Product blueberryScrunchie = new Product
            {
                Name = "Blueberry",
                Quantity = 4
            };
            DatabaseHelper.AddProduct(blueberryScrunchie);

            Product blackMoonScrunchie = new Product
            {
                Name = "Black Crescent Moon",
                Quantity = 5
            };
            DatabaseHelper.AddProduct(blackMoonScrunchie);

            Product birthdayPokemonScrunchie = new Product
            {
                Name = "Birthday Pokemon",
                Quantity = 2
            };
            DatabaseHelper.AddProduct(birthdayPokemonScrunchie);

            Product blackPokemonScrunchie = new Product
            {
                Name = "Black Pokemon",
                Quantity = 6
            };
            DatabaseHelper.AddProduct(blackPokemonScrunchie);

            Product salmonScrunchie = new Product
            {
                Name = "Salmon",
                Quantity = 3
            };

            DatabaseHelper.AddProduct(salmonScrunchie);

            Product walrusScrunchie = new Product
            {
                Name = "Walrus",
                Quantity = 1
            };

            DatabaseHelper.AddProduct(walrusScrunchie);


            Product butterflyScrunchie = new Product
            {
                Name = "Butterfly",
                Quantity = 5
            };

            DatabaseHelper.AddProduct(butterflyScrunchie);

            Product majesticHorseScrunchie = new Product
            {
                Name = "Majestic Horse",
                Quantity = 4
            };

            DatabaseHelper.AddProduct(majesticHorseScrunchie);

            Product sherbetScrunchie = new Product
            {
                Name = "Sherbet",
                Quantity = 6
            };

            Product brownNativeScrunchie = new Product
            {
                Name = "Brown Native",
                Quantity = 5
            };

            DatabaseHelper.AddProduct(brownNativeScrunchie);


            Product fireweedScrunchie = new Product
            {
                Name = "Fireweed",
                Quantity = 6
            };

            DatabaseHelper.AddProduct(fireweedScrunchie);

            Product underTheSeaScrunchie = new Product
            {
                Name = "Under The Sea",
                Quantity = 2
            };

            DatabaseHelper.AddProduct(underTheSeaScrunchie);


            Product bohoChicScruchie = new Product
            {
                Name = "Boho Chic",
                Quantity = 7
            };

            DatabaseHelper.AddProduct(bohoChicScruchie);

            Product brownPlaidScrunchie = new Product
            {
                Name = "Brown Plaid",
                Quantity = 8
            };

            DatabaseHelper.AddProduct(brownPlaidScrunchie);

            Product milkAndCookiesScrunchie = new Product
            {
                Name = "Milk and Cookies",
                Quantity = 8
            };

            DatabaseHelper.AddProduct(milkAndCookiesScrunchie);

            Product blueBeesScrunchie = new Product
            {
                Name = "Blue Bees",
                Quantity = 4
            };

            DatabaseHelper.AddProduct(blueBeesScrunchie);

            Product blackCherryScrunchie = new Product
            {
                Name = "Black Cherry",
                Quantity = 4
            };

            DatabaseHelper.AddProduct(blackCherryScrunchie);

            Product parkDaysScrunchie = new Product
            {
                Name = "Park Days",
                Quantity = 4
            };

            DatabaseHelper.AddProduct(parkDaysScrunchie);

            Product miscScrunchie = new Product
            {
                Name = "Misc",
                Quantity = 7
            };

            DatabaseHelper.AddProduct(miscScrunchie);

            Console.WriteLine("Retrieving your scrunchie inventory...\n");

            var products = DatabaseHelper.GetAllProducts;

            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.IDProduct}, Name: {p.Name}, Quantity{p.Quantity} , Stock: {p.StockQuantity}");
            }

            Console.WriteLine("\nInventory loaded successfully.");
        }

    }

        
    
}