namespace EE3206_WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_PriceColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.OrderItems", "Item_price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderItems", "Item_price", c => c.Int(nullable: false));
        }
    }
}
