using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryClasses;

namespace InventoryClasses
{
    public class InvContext : DbContext
    {
        public InvContext() : base(Statics.DBconnstr) // start up the default context to use the db conn str
        {

        }

        // Entity Framework Code First Migrations with an existing database
        // https://msdn.microsoft.com/en-us/library/dn579398(v=vs.113).aspx

        // Entity Framework Code First Migrations
        // https://msdn.microsoft.com/en-us/library/jj591621(v=vs.113).aspx


        
        public DbSet<CustomerInvoice> CustomerInvoice { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PackingSlip> PackingSlips { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        // Done
        public DbSet<Customer> Customers { get; set; }


    }
}
