namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpDates", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "ExtraPickup", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ExtraPickup");
            DropColumn("dbo.Customers", "PickUpDates");
        }
    }
}
