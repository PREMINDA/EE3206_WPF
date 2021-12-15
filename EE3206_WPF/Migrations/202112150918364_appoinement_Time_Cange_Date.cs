namespace EE3206_WPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appoinement_Time_Cange_Date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appoinments", "Appoinment_Date", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Appoinments", "Appoinment_Time", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appoinments", "Appoinment_Time", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Appoinments", "Appoinment_Date", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
