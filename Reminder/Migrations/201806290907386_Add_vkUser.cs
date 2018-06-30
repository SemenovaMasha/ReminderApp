namespace Reminder_desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_vkUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserSettingsModels", "vkUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserSettingsModels", "vkUser");
        }
    }
}
