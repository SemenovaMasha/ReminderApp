using Reminder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder_desktop_application
{
    public class TaskControler : IControler<Task>
    {
        //IStreamer<string, List<Task>> dataStreamer;
        IControler<Task> Controler;
        //FileStreamer fileStreamer = new FileStreamer();
        List<Task> dailyTasks = new List<Task>();
        public TaskServiceDB serviceDB;

        public TaskControler(IControler<Task> controler, TaskServiceDB s)
        {
            Controler = controler;
            serviceDB = s;
        }

        public delegate void NewTaskAppearedHandler(Task task);
        public event NewTaskAppearedHandler TaskAppeared;
        
        public List<Task> DailyTasks { get { return dailyTasks; } }


        public void Add(List<TaskModel> tasks)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.remind_flag)
                {
                    {
                        Controler.Add(new Task(task.Id, task.text, task.next_date, task.remind_flag, (int)task.period_min, (int)task.duration_min, (double)task.price, serviceDB));
                    }
                }
            }
        }


        public void Add(Task task)
        {
            if (task.remind_flag)
            {
                {
                    Controler.Add(task);
                }
            }

            serviceDB.addTask(new TaskModel
            {
                Id = task.guid,
                text = task.text,
                next_date = task.next_date,
                remind_flag = task.remind_flag,
                period_min = task.period_min,
                duration_min = task.duration_min,
                price = task.price
            });
        }

        public void Edit(Task task)
        {
            serviceDB.editTask(new TaskModel
            {
                Id = task.guid,
                text = task.text,
                next_date = task.next_date,
                remind_flag = task.remind_flag,
                period_min = task.period_min,
                duration_min = task.duration_min,
                price = task.price
            });

        }
        public void Remove(Task task)
        {
            try
            {
                serviceDB.deleteTask(new TaskModel
                {
                    Id = task.guid,
                    text = task.text,
                    next_date = task.next_date,
                    remind_flag = task.remind_flag,
                    period_min = task.period_min,
                    duration_min = task.duration_min,
                    price = task.price
                });
                Controler.Remove(task);
            }
            catch (Exception e)
            {
                throw new RemoveTaskException(e.ToString(), e);
            }
        }

        public void Stop()
        {
            Controler.Stop();
        }
        

        public List<TaskModel> getDailyTasks(DateTime day)
        {
            return serviceDB.getDailyTasks(day);
        }
        //public void reingin()
        //{
        //    fileStreamer.reingin();
        //}
    }
}
