namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappedEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderedItems",
                c => new
                    {
                        OrderedItemsID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ItemStored_ItemCategoryID = c.Int(),
                        order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderedItemsID)
                .ForeignKey("dbo.ItemCategories", t => t.ItemStored_ItemCategoryID)
                .ForeignKey("dbo.Orders", t => t.order_OrderID)
                .Index(t => t.ItemStored_ItemCategoryID)
                .Index(t => t.order_OrderID);
            
            CreateTable(
                "dbo.BackOrders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        DateOrdered = c.DateTime(nullable: false),
                        Customer_CustomerID = c.Int(),
                        ShippedFrom_WarehouseID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .Index(t => t.Customer_CustomerID)
                .Index(t => t.ShippedFrom_WarehouseID);
            
            AddColumn("dbo.CustomerInvoices", "NewCustomer_CustomerID", c => c.Int());
            AddColumn("dbo.Orders", "BackOrder_OrderID", c => c.Int());
            CreateIndex("dbo.CustomerInvoices", "NewCustomer_CustomerID");
            CreateIndex("dbo.Orders", "BackOrder_OrderID");
            AddForeignKey("dbo.CustomerInvoices", "NewCustomer_CustomerID", "dbo.Customers", "CustomerID");
            AddForeignKey("dbo.Orders", "BackOrder_OrderID", "dbo.BackOrders", "OrderID");
            DropColumn("dbo.Orders", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Orders", "BackOrder_OrderID", "dbo.BackOrders");
            DropForeignKey("dbo.CustomerInvoices", "NewCustomer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderedItems", "order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderedItems", "ItemStored_ItemCategoryID", "dbo.ItemCategories");
            DropIndex("dbo.BackOrders", new[] { "ShippedFrom_WarehouseID" });
            DropIndex("dbo.BackOrders", new[] { "Customer_CustomerID" });
            DropIndex("dbo.OrderedItems", new[] { "order_OrderID" });
            DropIndex("dbo.OrderedItems", new[] { "ItemStored_ItemCategoryID" });
            DropIndex("dbo.Orders", new[] { "BackOrder_OrderID" });
            DropIndex("dbo.CustomerInvoices", new[] { "NewCustomer_CustomerID" });
            DropColumn("dbo.Orders", "BackOrder_OrderID");
            DropColumn("dbo.CustomerInvoices", "NewCustomer_CustomerID");
            DropTable("dbo.BackOrders");
            DropTable("dbo.OrderedItems");
        }
    }
}
