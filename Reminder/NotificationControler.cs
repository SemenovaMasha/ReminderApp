using Quartz;
using Quartz.Impl;
using System;

namespace Reminder_desktop_application
{
    public class NotificationControler : IControler<Task>
    {
        ISchedulerFactory schedulerFactor = new StdSchedulerFactory();
        IScheduler scheduler;

        public NotificationControler()
        {
            scheduler = schedulerFactor.GetScheduler();
            scheduler.Start();
        }

        public void Add(Task task)
        {
            IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(task.next_date.ToString()).Build();
            //IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(task.JobKey).Build();
            taskToNotify.JobDataMap["Task"] = task;
           
            TriggerBuilder builder = TriggerBuilder.Create()
                    .StartAt(task.next_date);
            

            if (task.period_sec > 0)
            {
                builder.WithSimpleSchedule(x => x
                        .WithIntervalInSeconds(task.period_sec)
                        .RepeatForever())
                    .EndAt(task.next_date.AddSeconds(task.duration_sec));
            }

            ITrigger trigger = builder
                   .Build();
            
            //if (scheduler.CheckExists(taskToNotify.Key))
            //{
            //    scheduler.DeleteJob(taskToNotify.Key);
            //    Console.WriteLine("!"+((Task)taskToNotify.JobDataMap["Task"]).text);
            //}
            scheduler.ScheduleJob(taskToNotify, trigger);

            Console.WriteLine(((Task)taskToNotify.JobDataMap["Task"]).text);
        }

        public void Remove(Task task)
        {
            scheduler.DeleteJob(task.JobKey);
        }

        public void Stop()
        {
            scheduler.Shutdown();
        }
    }
}
