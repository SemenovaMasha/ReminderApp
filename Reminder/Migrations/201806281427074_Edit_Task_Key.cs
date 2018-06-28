namespace Reminder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edit_Task_Key : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TaskModels");
            AlterColumn("dbo.TaskModels", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.TaskModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TaskModels");
            AlterColumn("dbo.TaskModels", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.TaskModels", "Id");
        }
    }
}
