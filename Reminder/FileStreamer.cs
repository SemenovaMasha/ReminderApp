using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Reminder_desktop_application
{
    public class FileStreamer : IStreamer<string, List<Task>>
    {
        private string FILE_NAME = System.Configuration.ConfigurationManager.AppSettings["filePath"];
        public string[] data;
        
        public void addData(Task task)
        {
            using (StreamWriter fileStream = new StreamWriter(FILE_NAME, true))
            {
                fileStream.Write("\r\n");
                fileStream.Write(task.guid.ToString() + ",");
                fileStream.Write(task.text.ToString() + ",");
                fileStream.Write(task.next_date.ToString() + ",");
                fileStream.Write(task.remind_flag + ",");
                fileStream.Write(task.period_min + ",");
                fileStream.Write(task.duration_min + ",");
                fileStream.Write(task.price.ToString().Replace(",","."));
            }
        }

        public void deleteTask(Task task)
        {
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(FILE_NAME);
            bool first_line = true;
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.StartsWith(task.guid))
                {
                    if (!first_line)
                    {
                        n += Environment.NewLine;
                    }

                    n += strOldText ;
                    first_line = false;
                }
            }
            sr.Close();
            File.WriteAllText(FILE_NAME, n);
        }
   
        //реинжиниринг
        public void reingin()
        {
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(FILE_NAME);

            bool first_line = true;
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!first_line)
                {
                    n += Environment.NewLine;
                }
                string []words = strOldText.Split(',').ToArray<string>();

                //проходит по всем записям, сдвигает на сколько может
                Task task = new Task(words[0], words[1], Convert.ToDateTime(words[2]), Convert.ToBoolean(words[3]), Convert.ToInt32(words[4]),
                        Convert.ToInt32(words[5]), Convert.ToDouble(words[6].Replace(".", ",")));
                while (task.tryChange()) ;

                
                n += (task.guid.ToString() + ",");
                n += (task.text.ToString() + ",");
                n += (task.next_date.ToString() + ",");
                n += (task.remind_flag + ",");
                n += (task.period_min + ",");
                n += (task.duration_min + ",");
                n += (task.price.ToString().Replace(",", "."));
                
                first_line = false;
            }
            sr.Close();
            File.WriteAllText(FILE_NAME, n);
        }

        //изменить task
        public void editTask(Task task)
        {
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(FILE_NAME);

            bool first_line = true;
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!first_line)
                {
                    n += Environment.NewLine;
                }

                if (strOldText.StartsWith(task.guid))
                {
                    n +=(task.guid.ToString() + ",");
                    n +=(task.text.ToString() + ",");
                    n +=(task.next_date.ToString() + ",");
                    n += (task.remind_flag + ",");
                    n += (task.period_min + ",");
                    n += (task.duration_min + ",");
                    n += (task.price.ToString().Replace(",", "."));
                    
                }
                else
                {
                    n += strOldText;
                }
                first_line = false;
            }
            sr.Close();
            File.WriteAllText(FILE_NAME, n);

        }

        //загрузка записей на день
        public List<Task> getDailyTasks(DateTime day)
        {
            List<Task> list = new List<Task>();

            string[] lines = GetData();
            string[] words;
            foreach (string line in lines)
            {
                words = line.Split(',').ToArray<string>();

                if (Convert.ToDateTime(words[2]).ToShortDateString() == day.ToShortDateString())
                {
                    Task task = new Task(words[0], words[1], Convert.ToDateTime(words[2]), Convert.ToBoolean(words[3]), Convert.ToInt32(words[4]),
                        Convert.ToInt32(words[5]), Convert.ToDouble(words[6].Replace(".", ",")));
                    list.Add(task);
                }
            }
            return list;
        }
        public string[] GetData()
        {
            try
            {
                data = System.IO.File.ReadAllLines(FILE_NAME);
                return data;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException(e.ToString());
            }
        }
    }
}
