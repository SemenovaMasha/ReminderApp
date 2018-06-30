namespace Reminder_desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSettingsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        mailUserName = c.String(),
                        vkToken = c.String(),
                        mailMessageFlag = c.Boolean(nullable: false),
                        vkMessageFlag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserSettingsModels");
        }
    }
}
