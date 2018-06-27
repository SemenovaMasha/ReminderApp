using Quartz;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public class Task
    {
        public JobKey JobKey { get; set; }


        public string text { get; set; }
        public DateTime next_date { get; set; }
        public bool remind_flag { get; set; }
        public int period_sec { get; set; }
        public int duration_sec { get; set; }
        public double price { get; set; }


        public string time { get { return remind_flag ? next_date.ToShortTimeString() : ""; } }

        public delegate void NotificationEventHandler(object sender, EventArgs e);

        public event NotificationEventHandler TaskStarted;
        
        
        public Task(string text, DateTime next_date, bool remind_flag, int period_sec, int duration_sec, double price)
        {
            this.text = text;
            this.next_date = next_date;
            this.remind_flag = remind_flag;
            this.period_sec = period_sec;
            this.duration_sec = duration_sec;
            this.price = price;

            JobKey = new JobKey(next_date.ToShortDateString());
        }

        public void OnNotificationStarted(object sender, EventArgs e)
        {
            //add here vk, mail

            //if (TaskStarted != null)
            //    TaskStarted(sender, e);
            

            //MessageBox.Show("hmm");
            TaskNotification notificationForm = new TaskNotification(this);
            notificationForm.ShowDialog();
            notificationForm.TopMost = true;
        }
    }
}
