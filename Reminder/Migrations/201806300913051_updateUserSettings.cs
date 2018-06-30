namespace Reminder_desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserSettings : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserSettingsModels", "login", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.UserSettingsModels", "password", c => c.String(nullable: false, maxLength: 4000));
            AddColumn("dbo.UserSettingsModels", "secretWord", c => c.String(maxLength: 4000));
            DropTable("dbo.UserModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        login = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.UserSettingsModels", "secretWord");
            DropColumn("dbo.UserSettingsModels", "password");
            DropColumn("dbo.UserSettingsModels", "login");
        }
    }
}
