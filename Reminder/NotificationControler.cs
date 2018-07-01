using Quartz;
using Quartz.Impl;
using Reminder_desktop_application;
using System;

namespace Reminder_desktop_application
{
    public class NotificationControler : IControler<TaskModel>
    {
        ISchedulerFactory schedulerFactor = new StdSchedulerFactory();
        IScheduler scheduler;

        public NotificationControler()
        {
            scheduler = schedulerFactor.GetScheduler();
            scheduler.Start();
        }
        public void Add(TaskModel task)
        {
            if (task.next_date > DateTime.Now)
            {
                IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(new JobKey(task.Id.ToString())).Build();
                taskToNotify.JobDataMap["Task"] = task;

                TriggerBuilder builder = TriggerBuilder.Create()
                        .StartAt(task.next_date.AddMinutes(-10));
                //.StartAt(task.next_date.AddMinutes);


                if (task.period_min > 0)
                {
                    builder.WithSimpleSchedule(x => x
                            .WithIntervalInMinutes((int)(task.period_min))
                            .RepeatForever())
                        .EndAt(task.next_date.AddMinutes((int)(task.duration_min)));
                }

                ITrigger trigger = builder
                       .Build();
                
                scheduler.ScheduleJob(taskToNotify, trigger);
                
                
            }
        }

        public void Remove(TaskModel task)
        {
            scheduler.DeleteJob(new JobKey(task.Id.ToString()));

        }

        public void Stop()
        {
            scheduler.Shutdown();
        }
    }
}
