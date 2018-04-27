namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entities;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<InventoryClasses.InvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        
        /* 
         * This is the religion of database nuking;
         * Tired of all the migrations not working? Nuke the database and migrate anew;
         *           EXEC sp_MSforeachtable @command1 = "DROP TABLE ?"
         */

        protected override void Seed(InventoryClasses.InvContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Customers.AddOrUpdate(
                new Customer()
                {
                    CustomerID = 1,
                    Address = "9876 Boogie Street",
                    Name = "Iron Man", 
                    Phone = "945-345-6294",
                },
                new Customer()
                {
                    CustomerID = 2,
                    Address = "392 Monster Ave",
                    Name = "Incredible Hulk",
                    Phone = "362-739-7894",
                },
                new Customer()
                {
                    CustomerID = 3,
                    Address = "2456 Dorito Blvd.",
                    Name = "Loki Odinson",
                    Phone = "362-739-7894",
                },
                new Customer()
                {
                    CustomerID = 4,
                    Address = "737 Woot Street",
                    Name = "The Vision",
                    Phone = "739-4534-4749",
                },
                new Customer()
                {
                    CustomerID = 5,
                    Address = "5253 Tee Street",
                    Name = "Spiderman",
                    Phone = "353-689-2647",
                },
                new Customer()
                {
                    CustomerID = 6,
                    Address = "53467 Wakanda",
                    Name = "Black Panther",
                    Phone = "676-343-0808",
                }
            );


            context.ItemCategories.AddOrUpdate(
                new ItemCategory()
                {
                    ItemCategoryID = 1,
                    Name = "Paperclip",
                    Description = "Little metal clippy things that holds things together",
                    LocationInWarehouse = "Secion A",
                    MaxPerWarehouse = 10000,
                    Price = 0.01M,
                    RestockItemLimit = 1000,
                },  
                new ItemCategory()
                {
                    ItemCategoryID = 2,
                    Name = "Stapler",
                    Description = "The mother of staples",
                    LocationInWarehouse = "Secion B",
                    MaxPerWarehouse = 500,
                    Price = 8.70M,
                    RestockItemLimit = 250,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 3,
                    Name = "Staple",
                    Description = "There are many",
                    LocationInWarehouse = "Secion C",
                    MaxPerWarehouse = 10000,
                    Price = 8.70M,
                    RestockItemLimit = 250,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 4,
                    Name = "Push pin",
                    Description = "There are even more",
                    LocationInWarehouse = "Secion D",
                    MaxPerWarehouse = 10000,
                    Price = 0.02M,
                    RestockItemLimit = 500,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 5,
                    Name = "AA Battery",
                    Description = "Energizers pride and joy",
                    LocationInWarehouse = "Secion E",
                    MaxPerWarehouse = 2000,
                    Price = 1.05M,
                    RestockItemLimit = 200,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 6,
                    Name = "AAA Battery",
                    Description = "Energizers lesser pride and joy",
                    LocationInWarehouse = "Secion F",
                    MaxPerWarehouse = 2000,
                    Price = 0.98M,
                    RestockItemLimit = 200,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 7,
                    Name = "Paper pack",
                    Description = "Stack on stacks",
                    LocationInWarehouse = "Secion G",
                    MaxPerWarehouse = 700,
                    Price = 3.50M,
                    RestockItemLimit = 500,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 8,
                    Name = "Sticky Note",
                    Description = "When you need notes to stick around",
                    LocationInWarehouse = "Secion H",
                    MaxPerWarehouse = 300,
                    Price = 0.50M,
                    RestockItemLimit = 100,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 9,
                    Name = "Eraser",
                    Description = "For all those mistakes",
                    LocationInWarehouse = "Secion I",
                    MaxPerWarehouse = 100,
                    Price = 0.98M,
                    RestockItemLimit = 200,
                },
                new ItemCategory()
                {
                    ItemCategoryID = 10,
                    Name = "90's Gel Pen",
                    Description = "You know the kind.",
                    LocationInWarehouse = "Secion J",
                    MaxPerWarehouse = 100,
                    Price = 0.98M,
                    RestockItemLimit = 200,
                }

            );

            
            foreach (ItemCategory item in context.ItemCategories.ToList())
            {
                Vendor vendor = new Vendor()
                { 
                    VendorID = item.ItemCategoryID,
                    ItemProvided = item,
                    Name = "Vendor for " + item.Name,
                };
                context.Vendors.AddOrUpdate(vendor);
            }

            for (int i = 1; i <= 7; i++)
            {
                context.Warehouses.AddOrUpdate(new Warehouse()
                {
                    WarehouseID = i,
                    Address = i + "000 Wares Street",
                    Name = "Warehouse " + i,
                });
            }
            
            // fill the inventories of each of the warehouse


            int stockCount = 0;
            foreach (Warehouse house in context.Warehouses.ToList())
            foreach (ItemCategory item in context.ItemCategories.ToList())
            {
                stockCount++;
                context.ItemStocks.AddOrUpdate(new ItemStock()
                {
                    ItemStockID = stockCount,
                    ItemStored = item,
                    Quantity = item.MaxPerWarehouse,
                    Warehouse = house
                });
            }





        }
    }
}
