namespace DrivingLicense.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlastname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}
