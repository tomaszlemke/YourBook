namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            Sql("UPDATE MembershipTypes SET Name = 'Free' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Half-Year' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");

        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
