namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurrationInMonths, DurrationOfLoan) VALUES (1, 0, 0, 14)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurrationInMonths, DurrationOfLoan) VALUES (2, 30, 3, 21)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurrationInMonths, DurrationOfLoan) VALUES (3, 50, 6, 30)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurrationInMonths, DurrationOfLoan) VALUES (4, 80, 12, 90)");
        }
        
        public override void Down()
        {
        }
    }
}
