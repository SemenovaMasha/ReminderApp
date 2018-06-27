using System.Collections;
using System.Collections.Generic;
using System.IO;

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
                fileStream.Write(task.text.ToString() + ",");
                fileStream.Write(task.next_date.ToString() + ",");
                fileStream.Write(task.remind_flag + ",");
                fileStream.Write(task.period_sec + ",");
                fileStream.Write(task.duration_sec + ",");
                fileStream.Write(task.price.ToString().Replace(",","."));
            }
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
