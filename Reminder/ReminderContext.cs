
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
