namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Balance", c => c.Double());
            AlterColumn("dbo.Customers", "Monthlycharge", c => c.Double());
            AlterColumn("dbo.Customers", "PickupConfirmed", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PickupConfirmed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "Monthlycharge", c => c.Double(nullable: false));
            AlterColumn("dbo.Customers", "Balance", c => c.Double(nullable: false));
        }
    }
}
