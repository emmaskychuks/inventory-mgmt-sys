namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedOrderedItemsReference : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.OrderedItems", new[] { "order_OrderID" });
            RenameColumn(table: "dbo.OrderedItems", name: "ItemStored_ItemCategoryID", newName: "Item_ItemCategoryID");
            RenameIndex(table: "dbo.OrderedItems", name: "IX_ItemStored_ItemCategoryID", newName: "IX_Item_ItemCategoryID");
            CreateIndex("dbo.OrderedItems", "Order_OrderID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.OrderedItems", new[] { "Order_OrderID" });
            RenameIndex(table: "dbo.OrderedItems", name: "IX_Item_ItemCategoryID", newName: "IX_ItemStored_ItemCategoryID");
            RenameColumn(table: "dbo.OrderedItems", name: "Item_ItemCategoryID", newName: "ItemStored_ItemCategoryID");
            CreateIndex("dbo.OrderedItems", "order_OrderID");
        }
    }
}
