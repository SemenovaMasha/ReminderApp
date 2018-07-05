using System.Data.Entity;

namespace Reminder_desktop_application
{
    public class ReminderContext : DbContext
    {
        public ReminderContext() : base("Reminder")
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<UserSettingsModel> UserSettings { get; set; }
    }
}
