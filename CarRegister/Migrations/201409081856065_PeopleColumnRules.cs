namespace CarRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PeopleColumnRules : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
        }
    }
}
