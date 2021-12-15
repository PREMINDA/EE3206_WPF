namespace EE3206_WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appoinement_Time_Cange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appoinments", "Appoinment_Time", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appoinments", "Appoinment_Time", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
