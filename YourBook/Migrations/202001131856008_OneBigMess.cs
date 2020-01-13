namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneBigMess : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipTypeID" });
            AddColumn("dbo.Books", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.MembershipTypes", "DurrationInMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurrationInMonths", c => c.Byte(nullable: false));
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
            DropColumn("dbo.Books", "NumberAvailable");
            CreateIndex("dbo.Customers", "MembershipTypeID");
        }
    }
}
