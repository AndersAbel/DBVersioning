namespace CarRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarBrand : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Brand", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Brand");
        }
    }
}
