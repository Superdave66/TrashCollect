namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "PickUpDates");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PickUpDates", c => c.DateTime(nullable: false));
        }
    }
}
