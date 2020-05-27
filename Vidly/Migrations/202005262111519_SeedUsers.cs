namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3340cca7-b057-4ff4-a82f-8601d0c782cb', N'admin1@vidly.com', 0, N'AGvxgZeGg3ByX56IijtStUyEVwUfnHJ6HMyQUJDK7fsJgsgX4cVPniWbwNRI/iB7gA==', N'9cdc04ad-ddae-4a1a-9493-65765838572d', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9ed6badf-e1bf-4848-a67a-2ef401f58395', N'guest@vidly.com', 0, N'AKkl8I+l/8Bp6fTM+HIuLt86ylj6ZmmryTE1+ISFcA4QzqJsbEdhfeg66dXe8gVf+Q==', N'995da2fd-503e-4db9-bc0f-219d961fa4ae', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a7dc8a72-559d-42a9-8816-908bc50f4524', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3340cca7-b057-4ff4-a82f-8601d0c782cb', N'a7dc8a72-559d-42a9-8816-908bc50f4524')
");
        }
        
        public override void Down()
        {
        }
    }
}
