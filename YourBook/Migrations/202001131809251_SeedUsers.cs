namespace YourBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31dfa2e1-9db0-4b4c-bf37-da8796b5c0fc', N'admin@yourbook.com', 0, N'AGmNAEmfckakrp92rKxzc33d0HltMEi1uHjxjRKRZDeB04JbnoFjyzxEpMq76yfKWw==', N'53665d09-6817-4690-b1c3-df722dec9175', NULL, 0, 0, NULL, 1, 0, N'admin@yourbook.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d1b300d-2c59-473b-bd0c-77363e5175de', N'guest@yourbook.com', 0, N'AOZj1hiMp3xxVGEbT7pKCU1NLnzdzja5J7yFVklUjAUjlEAL78OM8ljLjdAEVuRMBw==', N'19dedb17-c9a5-411c-8cb9-cf2365a1047a', NULL, 0, 0, NULL, 1, 0, N'guest@yourbook.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'06810fcf-c0d3-4550-9a06-df5fc892110e', N'CanManageBook')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31dfa2e1-9db0-4b4c-bf37-da8796b5c0fc', N'06810fcf-c0d3-4550-9a06-df5fc892110e')


");
        }
        
        public override void Down()
        {
        }
    }
}
