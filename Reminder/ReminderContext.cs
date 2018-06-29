using Reminder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public class ReminderContext : DbContext
    {
        public ReminderContext() : base("Reminder")
        {
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<UserSettingsModel> UserSettings { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
    }
}
