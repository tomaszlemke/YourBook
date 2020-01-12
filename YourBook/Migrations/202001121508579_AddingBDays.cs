namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBDays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '01-08-2000' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '12-02-1986' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
