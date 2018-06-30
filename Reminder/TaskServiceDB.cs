using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reminder_desktop_application
{
    public class TaskServiceDB
    {
        private ReminderContext context;

        public TaskServiceDB()
        {
            this.context = new ReminderContext();
        }

        public void addTask(TaskModel task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }
        public void createSettingsIfNotExists()
        {
            int count = context.UserSettings.Count();
            if (count == 0)
            {
                context.UserSettings.Add(new UserSettingsModel
                {
                    vkToken = "",
                    vkMessageFlag = false,
                    mailMessageFlag = false,
                    mailUserName = "",
                    fontSize = 12,
                    login = "x",
                    password="x"
                });
                context.SaveChanges();
            }
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

        public void auth(string login, string password)
        {
            UserSettingsModel t = context.UserSettings.FirstOrDefault();
            t.login = login;
            t.password = password;
            context.SaveChanges();
        }

        public void editSettings(UserSettingsModel settings)
        {
            UserSettingsModel t = context.UserSettings.FirstOrDefault();

            t.mailUserName = settings.mailUserName;
            t.vkToken = settings.vkToken;
            if (t.vkUser != null)
            {
                t.vkMessageFlag = settings.vkMessageFlag;
            }
            t.mailMessageFlag = settings.mailMessageFlag;
            t.secretWord = settings.secretWord;


            context.SaveChanges();

            var g = context.UserSettings.FirstOrDefault();

        }
        public void editToken(string token,string login)
        {
            UserSettingsModel t = context.UserSettings.FirstOrDefault();
            if (t == null)
            {
                throw new Exception("Элемент не найден");
            }
            t.vkToken = token == "" ? "" : Crypter.Encrypt(token);
            //   t.vkUser = login == "" ? "" : Crypter.Encrypt(login);
            t.vkUser = login;
            context.SaveChanges();
        }

        public string getToken()
        {
            UserSettingsModel t = context.UserSettings.FirstOrDefault();
            if (t == null)
            {
                throw new Exception("Элемент не найден");
            }
            try
            {
                return Crypter.Decrypt(t.vkToken);
            }
            catch
            {
                return null;
            }
        }

        public UserSettingsModel getUserSettings()
        {
            var h = context.UserSettings.ToList();
            return context.UserSettings.FirstOrDefault();
        }

        public List<TaskModel> getDailyTasks(DateTime day)
        {
            List<TaskModel> list = context.Tasks.Where(t => t.next_date.Day == day.Day & t.next_date.Month == day.Month & t.next_date.Year == day.Year).ToList();
            return list;
        }
        public double getDailySum(DateTime day)
        {
            var list = context.Tasks.Where(t => t.next_date.Day == day.Day & t.next_date.Month == day.Month & t.next_date.Year == day.Year);

            if (list.Count() == 0)
                return 0;
            else
                return (double)list.Sum(x => x.price);
        }
        public double getYearSum(DateTime year)
        {
            var list = context.Tasks.Where(t => t.next_date.Year == year.Year);

            if (list.Count() == 0)
                return 0;
            else
                return (double)list.Sum(x => x.price);
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
