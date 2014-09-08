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
                        RegNo = c.String(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.People", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "OwnerId", "dbo.People");
            DropIndex("dbo.Cars", new[] { "OwnerId" });
            DropTable("dbo.Cars");
        }
    }
}
