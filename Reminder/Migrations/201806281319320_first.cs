namespace Reminder_desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskModels");
        }
    }
}
