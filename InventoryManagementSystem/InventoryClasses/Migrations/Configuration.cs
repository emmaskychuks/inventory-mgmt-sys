namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InventoryClasses.InvContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

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
                    Name = "Paperclips",
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
                    Name = "Staples",
                    Description = "There are many",
                    LocationInWarehouse = "Secion C",
                    MaxPerWarehouse = 10000,
                    Price = 8.70M,
                    RestockItemLimit = 250,
                }

            );


            context.Vendors.AddOrUpdate(
                new Vendor()
                {
                    VendorID = 1,
                    Name = "Vendor 1",
                    ItemProvided = 
                }

            );



        }
    }
}
