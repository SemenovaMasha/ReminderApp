using Quartz;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public class Task
    {
        FileStreamer fileStreamer = new FileStreamer();
        public JobKey JobKey { get; set; }

        public string guid { get; set; }
        public string text { get; set; }
        public DateTime next_date { get; set; }
        public bool remind_flag { get; set; }
        public int period_min { get; set; }
        public int duration_min { get; set; }
        public double price { get; set; }


        public string time { get { return remind_flag ? next_date.ToShortTimeString() : ""; } }

        public delegate void NotificationEventHandler(object sender, EventArgs e);

        public event NotificationEventHandler TaskStarted;
        
        
        public Task(string guid ,string text, DateTime next_date, bool remind_flag, int period_min, int duration_min, double price)
        {
            this.guid = guid;
            this.text = text;
            this.next_date = next_date;
            this.remind_flag = remind_flag;
            this.period_min = period_min;
            this.duration_min = duration_min;
            this.price = price;

            JobKey = new JobKey(text+" date:"+next_date.ToString());
        }

        public void OnNotificationStarted(object sender, EventArgs e)
        {
            changeNextDate();            
            fileStreamer.editTask(this);

            // тут оповещение вк и почты

            TaskNotification notificationForm = new TaskNotification(this);
            notificationForm.ShowDialog();
            notificationForm.TopMost = true;
            
        }

        public void changeNextDate()
        {
            DateTime newDate = next_date.AddMinutes(period_min);
            duration_min -= period_min;

            if (duration_min > 0)
            {
                next_date = newDate;
            }
        }
        public bool tryChange()
        {
            bool changed = false;
            if (remind_flag&& duration_min>0&&next_date<DateTime.Now)
            {
                DateTime newDate = next_date.AddMinutes(period_min);
                
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
