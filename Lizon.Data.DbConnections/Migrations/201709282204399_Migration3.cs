namespace Lizon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            AddColumn("dbo.AppUser", "AppUserMiddleName", c => c.String());
            AddColumn("dbo.AppUser", "AppUserPhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AppUser", "AppUserFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.AppUser", "AppUserLastName", c => c.String(nullable: false));
            AlterColumn("dbo.AppUser", "AppUserName", c => c.String(nullable: false));
            AlterColumn("dbo.AppUser", "AppUserPassword", c => c.String(nullable: false));
            AlterColumn("dbo.AppUser", "AppUserConfirmPassword", c => c.String(nullable: false));
            DropTable("dbo.Vendor");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            AlterColumn("dbo.AppUser", "AppUserConfirmPassword", c => c.String());
            AlterColumn("dbo.AppUser", "AppUserPassword", c => c.String());
            AlterColumn("dbo.AppUser", "AppUserName", c => c.String());
            AlterColumn("dbo.AppUser", "AppUserLastName", c => c.String());
            AlterColumn("dbo.AppUser", "AppUserFirstName", c => c.String());
            DropColumn("dbo.AppUser", "AppUserPhoneNumber");
            DropColumn("dbo.AppUser", "AppUserMiddleName");
            DropTable("dbo.Role");
        }
    }
}
