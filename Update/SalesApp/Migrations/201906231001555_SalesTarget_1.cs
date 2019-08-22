namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesTarget : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesPersons", "SalesTarget", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 1000.00M)); //if new person is entered into db, and value is not set, it takes the default value.
            AddColumn("dbo.SalesRegions", "SalesTarget", c => c.Decimal(nullable: false, precision: 18, scale: 2, defaultValue: 10000.00M)); //if new region is entered into db, and value is not set, it takes the default value.
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalesRegions", "SalesTarget");
            DropColumn("dbo.SalesPersons", "SalesTarget");
        }
    }
}
