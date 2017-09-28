namespace Lizon.Data.DbConnections.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUser",
                c => new
                    {
                        AppUserId = c.Int(nullable: false, identity: true),
                        AppUserFirstName = c.String(nullable: false),
                        AppUserLastName = c.String(nullable: false),
                        AppUserMiddleName = c.String(),
                        AppUserName = c.String(nullable: false),
                        AppUserPassword = c.String(nullable: false),
                        AppUserConfirmPassword = c.String(nullable: false),
                        AppUserPhoneNumber = c.String(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppUserId)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppUser", "RoleId", "dbo.Role");
            DropIndex("dbo.AppUser", new[] { "RoleId" });
            DropTable("dbo.Role");
            DropTable("dbo.AppUser");
        }
    }
}
