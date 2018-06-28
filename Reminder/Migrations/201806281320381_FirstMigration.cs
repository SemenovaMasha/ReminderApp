namespace Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaskModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        text = c.String(),
                        next_date = c.DateTime(nullable: false),
                        remind_flag = c.Boolean(nullable: false),
                        period_min = c.Int(),
                        duration_min = c.Int(),
                        price = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropTable("dbo.TaskModels");
        }
    }
}
