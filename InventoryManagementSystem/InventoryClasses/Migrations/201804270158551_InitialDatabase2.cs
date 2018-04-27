namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderCode = c.String(maxLength: 6),
                        DateOrdered = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Customer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Customer_CustomerID);
            
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
                "dbo.OrderedItems",
                c => new
                    {
                        OrderedItemsID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Item_ItemCategoryID = c.Int(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderedItemsID)
                .ForeignKey("dbo.ItemCategories", t => t.Item_ItemCategoryID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.Item_ItemCategoryID)
                .Index(t => t.Order_OrderID);
            
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
                "dbo.CustomerInvoices",
                c => new
                    {
                        CustomerInvoiceID = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesTax = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrgPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FulfilledOrder_OrderID = c.Int(),
                        NewCustomer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerInvoiceID)
                .ForeignKey("dbo.Orders", t => t.FulfilledOrder_OrderID)
                .ForeignKey("dbo.Customers", t => t.NewCustomer_CustomerID)
                .Index(t => t.FulfilledOrder_OrderID)
                .Index(t => t.NewCustomer_CustomerID);
            
            CreateTable(
                "dbo.ItemStocks",
                c => new
                    {
                        ItemStockID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ItemStored_ItemCategoryID = c.Int(),
                        Warehouse_WarehouseID = c.Int(),
                    })
                .PrimaryKey(t => t.ItemStockID)
                .ForeignKey("dbo.ItemCategories", t => t.ItemStored_ItemCategoryID)
                .ForeignKey("dbo.Warehouses", t => t.Warehouse_WarehouseID)
                .Index(t => t.ItemStored_ItemCategoryID)
                .Index(t => t.Warehouse_WarehouseID);
            
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
            DropForeignKey("dbo.ItemStocks", "Warehouse_WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.ItemStocks", "ItemStored_ItemCategoryID", "dbo.ItemCategories");
            DropForeignKey("dbo.CustomerInvoices", "NewCustomer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerInvoices", "FulfilledOrder_OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderedItems", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "Customer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.OrderedItems", "Item_ItemCategoryID", "dbo.ItemCategories");
            DropIndex("dbo.Vendors", new[] { "ItemProvided_ItemCategoryID" });
            DropIndex("dbo.PackingSlips", new[] { "WarehouseToShipFrom_WarehouseID" });
            DropIndex("dbo.PackingSlips", new[] { "OrderBeingPacked_OrderID" });
            DropIndex("dbo.PackingSlips", new[] { "CustomerToShipTo_CustomerID" });
            DropIndex("dbo.ItemStocks", new[] { "Warehouse_WarehouseID" });
            DropIndex("dbo.ItemStocks", new[] { "ItemStored_ItemCategoryID" });
            DropIndex("dbo.CustomerInvoices", new[] { "NewCustomer_CustomerID" });
            DropIndex("dbo.CustomerInvoices", new[] { "FulfilledOrder_OrderID" });
            DropIndex("dbo.OrderedItems", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderedItems", new[] { "Item_ItemCategoryID" });
            DropIndex("dbo.Orders", new[] { "Customer_CustomerID" });
            DropTable("dbo.Vendors");
            DropTable("dbo.PackingSlips");
            DropTable("dbo.Warehouses");
            DropTable("dbo.ItemStocks");
            DropTable("dbo.CustomerInvoices");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.OrderedItems");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
        }
    }
}
