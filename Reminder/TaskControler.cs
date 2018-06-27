using System;
using System.Collections.Generic;
using System.Linq;

namespace Reminder_desktop_application
{
    public class TaskControler : IControler<Task>
    {
        IStreamer<string, List<Task>> dataStreamer;
        IControler<Task> Controler;
        FileStreamer fileStreamer = new FileStreamer();
        List<Task> dailyTasks = new List<Task>();

        public TaskControler(IStreamer<string, List<Task>> streamer, IControler<Task> controler)
        {
            dataStreamer = streamer;
            Controler = controler;
        }

        public delegate void NewTaskAppearedHandler(Task task);
        public event NewTaskAppearedHandler TaskAppeared;
        
        public List<Task> DailyTasks { get { return dailyTasks; } }


        public void Add(List<Task> tasks)
        {
            foreach(Task task in tasks)
            {
                if (task.remind_flag)
                {
                    {
                        Controler.Add(task);
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


            //тут добавляется Task в БД
            fileStreamer.addData(task);

        }

        public void Remove(Task task)
        {
            try
            {
                //if (task.isDailyNotifed)
                //{
                //    dailyTasks.Remove(task);
                //}
                //else
                //{
                //    string key = task.StartingDate.ToShortDateString();
                //    tasksForEachDay[key].Remove(task);
                //}
                Controler.Remove(task);
            }
            catch (Exception e)
            {
                throw new RemoveTaskException(e.ToString(), e);
            }
        }

        public void Stop()
        {
            //System.Threading.Tasks.Task savingTask = new System.Threading.Tasks.Task(
            //    () => {
            //        dataStreamer.SaveData(tasksForEachDay);
            //        dataStreamer.SaveData(dailyTasks);
            //    });
            //savingTask.Start();
            //Controler.Stop();
            //System.Threading.Tasks.Task.WaitAll(savingTask);

            Controler.Stop();
        }
        

        public List<Task> getDailyTasks(DateTime day)
        {
            List<Task> list = new List<Task>();

            string[] lines = dataStreamer.GetData();
            string[] words;
            foreach (string line in lines)
            {
                words = line.Split(',').ToArray<string>();

                if (Convert.ToDateTime(words[1]).ToShortDateString() == day.ToShortDateString())
                {
                    Task task = new Task(words[0], Convert.ToDateTime(words[1]), Convert.ToBoolean(words[2]), Convert.ToInt32(words[3]),
                        Convert.ToInt32(words[4]), Convert.ToDouble(words[5].Replace(".", ",")));
                    list.Add(task);
                }
            }
            return list;
        }
    }
}
