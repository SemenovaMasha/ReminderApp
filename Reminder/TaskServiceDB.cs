using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<TaskModel> GetList()
        {
            List<TaskModel> result = context.Tasks.ToList();
            return result;
        }

    }
}
