namespace EE3206_WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addLinkCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Link", c => c.String(nullable: false));
            AddColumn("dbo.Services", "Link", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Link");
            DropColumn("dbo.Products", "Link");
        }
    }
}
