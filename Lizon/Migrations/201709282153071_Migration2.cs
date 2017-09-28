namespace Lizon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AppUser", "AppUserFirstName", c => c.String());
            AddColumn("dbo.AppUser", "AppUserLastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AppUser", "AppUserLastName");
            DropColumn("dbo.AppUser", "AppUserFirstName");
        }
    }
}
