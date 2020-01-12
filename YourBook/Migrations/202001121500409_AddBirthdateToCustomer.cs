namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {

            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());

            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
            DropTable("dbo.Books");
        }
    }
}
