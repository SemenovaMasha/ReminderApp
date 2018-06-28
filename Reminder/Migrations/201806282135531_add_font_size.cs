namespace Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_font_size : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserSettingsModels", "fontSize", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserSettingsModels", "fontSize");
        }
    }
}
