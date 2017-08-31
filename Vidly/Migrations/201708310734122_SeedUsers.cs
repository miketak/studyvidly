using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'141340ab-e817-4f10-ae06-4e999cd8b7bb', N'admin@test.com', 0, N'AG62G1xkyyoK6nsgnXTtgkE7CidMRqHx62IuJKnergZMoq3m5CxuG71aSzv+rEza1Q==', N'9f88430d-036f-4ad7-bf8d-5d33c71dc657', NULL, 0, 0, NULL, 1, 0, N'admin@test.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5ca7d037-4310-4553-bec6-8b3372b7f56d', N'guest@vidly.com', 0, N'APJEcHrRQaFa2s74lEWBC1OjVh4aTluEmC6gpTHhmgMBM+/CHjLCWfYCyHSW9b51kA==', N'9ce5ece3-1f05-4039-94cf-30b91d7291e6', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8e21612d-bc74-4a41-bc1c-0eaad24eaa1c', N'admin@vidly.com', 0, N'AH9g2t6eE+nI7qR1efOgISLFODh2vhXJPF3K1WdwgVonWAEYn4UmCJhfTtWAeu+2+g==', N'dc5e036f-9bbc-4bcf-8acf-4743dc91409a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ffa06f46-fd62-432e-920d-1806c0a03d11', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8e21612d-bc74-4a41-bc1c-0eaad24eaa1c', N'ffa06f46-fd62-432e-920d-1806c0a03d11')
                ");
        }

        public override void Down()
        {
        }
    }
}