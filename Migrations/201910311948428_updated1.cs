namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PickUpDates", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "PickUpDates");
        }
    }
}
