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
            if (task.next_date > DateTime.Now)
            {

                IJobDetail taskToNotify = JobBuilder.Create<Notification>().WithIdentity(task.JobKey).Build();
                taskToNotify.JobDataMap["Task"] = task;

                TriggerBuilder builder = TriggerBuilder.Create()
                        .StartAt(task.next_date);


                if (task.period_min > 0)
                {
                    builder.WithSimpleSchedule(x => x
                            .WithIntervalInMinutes(task.period_min)
                            .RepeatForever())
                        .EndAt(task.next_date.AddMinutes(task.duration_min));
                }

                ITrigger trigger = builder
                       .Build();
                
                scheduler.ScheduleJob(taskToNotify, trigger);
                
            }
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
