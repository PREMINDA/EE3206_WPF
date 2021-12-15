namespace EE3206_WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appoinement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appoinments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Appoinment_Date = c.String(nullable: false, maxLength: 10),
                        Appoinment_Time = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.AppoiServices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ServiceID = c.Int(nullable: false),
                        Appoinment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Services", t => t.ServiceID, cascadeDelete: true)
                .ForeignKey("dbo.Appoinments", t => t.Appoinment_ID)
                .Index(t => t.ServiceID)
                .Index(t => t.Appoinment_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appoinments", "UserID", "dbo.Users");
            DropForeignKey("dbo.AppoiServices", "Appoinment_ID", "dbo.Appoinments");
            DropForeignKey("dbo.AppoiServices", "ServiceID", "dbo.Services");
            DropIndex("dbo.AppoiServices", new[] { "Appoinment_ID" });
            DropIndex("dbo.AppoiServices", new[] { "ServiceID" });
            DropIndex("dbo.Appoinments", new[] { "UserID" });
            DropTable("dbo.AppoiServices");
            DropTable("dbo.Appoinments");
        }
    }
}
