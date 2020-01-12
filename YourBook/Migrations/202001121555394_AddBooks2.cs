namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooks2 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Books ON");
            Sql("INSERT INTO Books (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, Author) VALUES (1, 'Abc', 1, 2000-01-01, 1900-01-01, 6, 'XYZ')");
            Sql("SET IDENTITY_INSERT Books OFF");
        }
        
        public override void Down()
        {
        }
    }
}
