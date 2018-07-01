﻿using Quartz;
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
        public JobKey JobKey { get; set; }

        public void generateJobKey()
        {
            JobKey = new JobKey(text + " date:" + next_date.ToString());
            Console.WriteLine(text + " date:" + next_date.ToString());

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
            Console.WriteLine(next_date+"1!"+ duration_min);
            DateTime newDate = next_date.AddMinutes((int)(period_min));
            duration_min -= period_min;

            if (duration_min > 0)
            {
                next_date = newDate;
            }
            Console.WriteLine("1"+next_date);
        }
        
        public bool tryChange()
        {
            Console.WriteLine(next_date + "!" + duration_min);
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
            Console.WriteLine(next_date);
            return changed;
        }
    }
}
