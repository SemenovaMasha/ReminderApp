namespace Reminder_desktop_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableUserModel : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
