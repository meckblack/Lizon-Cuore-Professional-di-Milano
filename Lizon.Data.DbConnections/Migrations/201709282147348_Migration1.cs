namespace Lizon.Migrations
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
                        AppUserName = c.String(),
                        AppUserPassword = c.String(),
                        AppUserConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.AppUserId);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendor");
            DropTable("dbo.AppUser");
        }
    }
}
