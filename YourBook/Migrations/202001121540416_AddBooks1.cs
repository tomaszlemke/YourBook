namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooks1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 255));
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Author");
        }
    }
}
