using Quartz;
using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_desktop_application
{
    public delegate void NotificationEventHandler();
    public class TaskModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public string text { get; set; }

        [Required]
        public DateTime next_date { get; set; }

        [Required]
        public bool remind_flag { get; set; }

        public int? period_min { get; set; }

        public int? duration_min { get; set; }

        public double? price { get; set; }

        public TaskModel()
        {
            Id = Guid.NewGuid();

        }

        [NotMapped]
        public string time { get { return remind_flag ? next_date.ToShortTimeString() : ""; } }

        [NotMapped]
        public string displayText { get {
                string[] lines = text.Replace("\r","").Split('\n');

                string displayText = lines.Length > 4 ? lines[0] + "\n" + lines[1] + "\n" + lines[2] + "\n" + lines[3] + "..." : text;
                
                return displayText.Length>200?displayText.Substring(0,200)+"...":displayText;
            } }

        [NotMapped]
        public JobKey JobKey { get; set; }

        public void generateJobKey()
        {
            JobKey = new JobKey(text + " date:" + next_date.ToString());
        }
        
        public void OnNotificationStarted(object sender, EventArgs e)
        {
            changeNextDate();
            ReminderContext context = new ReminderContext();
            TaskServiceDB serviceDB = new TaskServiceDB();
            serviceDB.editTask(this);
                       
            TaskNotification notificationForm = new TaskNotification(this);
            notificationForm.ShowDialog();
            notificationForm.TopMost = true;

        }
        
        public void changeNextDate()
        {
            DateTime newDate = next_date.AddMinutes((int)(period_min));
            duration_min -= period_min;

            if (duration_min > 0)
            {
                next_date = newDate;
            }
        }
        
        public bool tryChange()
        {
            bool changed = false;
            if (remind_flag && duration_min > 0 && next_date < DateTime.Now)
            {
                DateTime newDate = next_date.AddMinutes((int)(period_min));

                duration_min -= period_min;

                if (duration_min > 0)
                {
                    next_date = newDate;
                }

                changed = true;
            }
            return changed;
        }
    }
}
