using Quartz;
using Reminder;
using System;
using System.Threading.Tasks;

namespace Reminder_desktop_application
{
    public class Notification : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            JobDataMap data = context.JobDetail.JobDataMap;
            TaskModel task = (TaskModel)data["Task"];
            task.OnNotificationStarted(task, EventArgs.Empty);
            
        }
        
    }
}
