namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedRemainingEntities : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemStocks", "Warehouse_WarehouseID", "dbo.Warehouses");
            DropForeignKey("dbo.ItemStocks", "ItemStored_ItemCategoryID", "dbo.ItemCategories");
            DropIndex("dbo.ItemStocks", new[] { "Warehouse_WarehouseID" });
            DropIndex("dbo.ItemStocks", new[] { "ItemStored_ItemCategoryID" });
            DropTable("dbo.ItemStocks");
        }
    }
}
