namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerInvoices",
                c => new
                    {
                        CustomerInvoiceID = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrgPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FulfilledOrder_OrderID = c.Int(),
                        UnfulfilledOrder_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerInvoiceID)
                .ForeignKey("dbo.Orders", t => t.FulfilledOrder_OrderID)
                .ForeignKey("dbo.Orders", t => t.UnfulfilledOrder_OrderID)
                .Index(t => t.FulfilledOrder_OrderID)
                .Index(t => t.UnfulfilledOrder_OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        DateOrdered = c.DateTime(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Customer_CustomerID = c.Int(),
                        ShippedFrom_WarehouseID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .ForeignKey("dbo.Warehouses", t => t.ShippedFrom_WarehouseID)
                .Index(t => t.Customer_CustomerID)
                .Index(t => t.ShippedFrom_WarehouseID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        WarehouseID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.WarehouseID);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        ItemCategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        RestockItemLimit = c.Int(nullable: false),
                        MaxPerWarehouse = c.Int(nullable: false),
                        LocationInWarehouse = c.String(),
                    })
                .PrimaryKey(t => t.ItemCategoryID);
            
            CreateTable(
                "dbo.PackingSlips",
                c => new
                    {
                        PackingSlipID = c.Int(nullable: false, identity: true),
                        CustomerToShipTo_CustomerID = c.Int(),
                        OrderBeingPacked_OrderID = c.Int(),
                        WarehouseToShipFrom_WarehouseID = c.Int(),
                    })
                .PrimaryKey(t => t.PackingSlipID)
                .ForeignKey("dbo.Customers", t => t.CustomerToShipTo_CustomerID)
                .ForeignKey("dbo.Orders", t => t.OrderBeingPacked_OrderID)
                .ForeignKey("dbo.Warehouses", t => t.WarehouseToShipFrom_WarehouseID)
                .Index(t => t.CustomerToShipTo_CustomerID)
                .Index(t => t.OrderBeingPacked_OrderID)
                .Index(t => t.WarehouseToShipFrom_WarehouseID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ItemProvided_ItemCategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.VendorID)
                .ForeignKey("dbo.ItemCategories", t => t.ItemProvided_ItemCategoryID)
                .Index(t => t.ItemProvided_ItemCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendors", "ItemProvided_ItemCategoryID", "dbo.ItemCategories");
            DropForeignKey("dbo.PackingSlips", "WarehouseToShipFrom_WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.PackingSlips", "OrderBeingPacked_OrderID", "dbo.Orders");
            DropForeignKey("dbo.PackingSlips", "CustomerToShipTo_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerInvoices", "UnfulfilledOrder_OrderID", "dbo.Orders");
            DropForeignKey("dbo.CustomerInvoices", "FulfilledOrder_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ShippedFrom_WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.Orders", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.Vendors", new[] { "ItemProvided_ItemCategoryID" });
            DropIndex("dbo.PackingSlips", new[] { "WarehouseToShipFrom_WarehouseID" });
            DropIndex("dbo.PackingSlips", new[] { "OrderBeingPacked_OrderID" });
            DropIndex("dbo.PackingSlips", new[] { "CustomerToShipTo_CustomerID" });
            DropIndex("dbo.Orders", new[] { "ShippedFrom_WarehouseID" });
            DropIndex("dbo.Orders", new[] { "Customer_CustomerID" });
            DropIndex("dbo.CustomerInvoices", new[] { "UnfulfilledOrder_OrderID" });
            DropIndex("dbo.CustomerInvoices", new[] { "FulfilledOrder_OrderID" });
            DropTable("dbo.Vendors");
            DropTable("dbo.PackingSlips");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.CustomerInvoices");
        }
    }
}
