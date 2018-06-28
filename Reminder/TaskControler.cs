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
            
            fileStreamer.addData(task);

        }

        public void Edit(Task task)
        {
            fileStreamer.editTask(task);

        }
        public void Remove(Task task)
        {
            try
            {
                fileStreamer.deleteTask(task);
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
        

        public List<Task> getDailyTasks(DateTime day)
        {
            return fileStreamer.getDailyTasks(day);
        }
        public void reingin()
        {
            fileStreamer.reingin();
        }
    }
}
