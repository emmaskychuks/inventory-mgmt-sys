namespace InventoryClasses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRestraintsToOrderTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "DateOrdered", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "DateOrdered", c => c.DateTime());
        }
    }
}
