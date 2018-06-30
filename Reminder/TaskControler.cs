using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder_desktop_application
{
    public class TaskControler : IControler<TaskModel>
    {
        public IControler<TaskModel> Controler;
        List<TaskModel> dailyTasks = new List<TaskModel>();
        public TaskServiceDB serviceDB;

        public TaskControler(IControler<TaskModel> controler, TaskServiceDB s)
        {
            Controler = controler;
            serviceDB = s;
        }
        
        
        public List<TaskModel> DailyTasks { get { return dailyTasks; } }
        
        public void Add(List<TaskModel> tasks)
        {
            foreach (TaskModel task in tasks)
            {
                if (task.remind_flag)
                {
                    {
                        Controler.Add(task);
                    }
                }
            }
        }
        public void Add(TaskModel task)
        {
            if (task.remind_flag)
            {
                {
                    Controler.Add(task);
                }
            }

            serviceDB.addTask(task);
        }
        
        public void Edit(TaskModel task)
        {
            serviceDB.editTask(task);

        }

        public void Remove(TaskModel task)
        {
            try
            {
                serviceDB.deleteTask(task);
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
        public double getDailySum(DateTime day)
        {
            return serviceDB.getDailySum(day);
        }
        public List<TaskModel> getYearTasks(DateTime year)
        {
            return serviceDB.getYearTasks(year);
        }
        public double getYearSum(DateTime year)
        {
            return serviceDB.getYearSum(year);
        }

        public void reingin()
        {
            foreach(TaskModel task  in serviceDB.GetList())
            {
               while (task.tryChange()) ;
                serviceDB.editTask(task);
            }
        }
    }
}
