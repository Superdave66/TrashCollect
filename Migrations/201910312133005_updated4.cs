namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Customers", "ExtraPickup", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "ExtraPickup", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
