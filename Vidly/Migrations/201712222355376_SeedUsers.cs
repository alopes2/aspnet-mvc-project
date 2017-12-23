namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da0fa44c-adb5-4c01-bbae-438fd622cf3e', N'guest@vidly.com', 0, N'AIWpfvlOEhbpafrWof+Ly/qgLuO1+sJ6AmMLX5f1Fw5YPh4j2xOrGXFiWHvIW7QMdA==', N'1b812518-c1a4-4883-8a5b-be9dd666fb80', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f86b8a31-a30e-47ea-adf8-a13dfd0d55d5', N'admin@vidly.com', 0, N'ADSmix9EJSTeuSuJFN/EuMcs1TFu03zROL46YgeycvZZ/IsXjfqTW0njdZYjS/pLJw==', N'592b590d-6524-47d8-b160-e5f35ece5bea', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2697c7eb-18a1-4e4b-89e6-3bdc0f87859f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f86b8a31-a30e-47ea-adf8-a13dfd0d55d5', N'2697c7eb-18a1-4e4b-89e6-3bdc0f87859f')

");
        }
        
        public override void Down()
        {
        }
    }
}
