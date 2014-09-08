namespace CarRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarColour : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Colour", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Colour");
        }
    }
}
