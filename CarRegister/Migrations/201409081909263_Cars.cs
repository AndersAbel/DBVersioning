namespace CarRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Int(nullable: false),
                        RegNo = c.String(maxLength: 6),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.People", t => t.OwnerId)
                .Index(t => t.OwnerId)
                .Index(t => t.RegNo, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "OwnerId", "dbo.People");
            DropIndex("dbo.Cars", new[] { "RegNo" });
            DropIndex("dbo.Cars", new[] { "OwnerId" });
            DropTable("dbo.Cars");
        }
    }
}
