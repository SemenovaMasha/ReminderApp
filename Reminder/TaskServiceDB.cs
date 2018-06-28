using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reminder
{
    public class TaskServiceDB
    {
        private ReminderContext context;

        public TaskServiceDB(ReminderContext context)
        {
            this.context = context;
        }

        public void addTask(TaskModel task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public void deleteTask(TaskModel task)
        {
            TaskModel t = context.Tasks.FirstOrDefault(x => x.Id == task.Id);
            if (t == null)
            {
                throw new Exception("Элемент не найден");
            }
            context.Tasks.Remove(t);
            context.SaveChanges();
        }

        public void editTask(TaskModel task)
        {
            TaskModel t = context.Tasks.FirstOrDefault(x => x.Id == task.Id);
            if (t == null)
            {
                throw new Exception("Элемент не найден");
            }
            t.next_date = task.next_date;
            t.period_min = task.period_min;
            t.price = task.price;
            t.remind_flag = task.remind_flag;
            t.text = task.text;
            context.SaveChanges();
        }

        public List<TaskModel> getDailyTasks(DateTime day)
        {
            List<TaskModel> list = context.Tasks.Where(t => t.next_date.Day == day.Day).ToList();//из БД только дату нужно!
            return list;
        }
        public List<TaskModel> getYearTasks(DateTime day)
        {
            List<TaskModel> list = context.Tasks.Where(t => t.next_date.Year == day.Year).ToList();
            return list;
        }

        public List<TaskModel> GetList()
        {
            List<TaskModel> result = context.Tasks.ToList();

            foreach (TaskModel task in result)
            {
                try
                {
                    Console.WriteLine(task.JobKey.ToString());
                }
                catch
                {
                    Console.WriteLine("Asd");
                }
            }
            return result;
        }
        

    }
}
