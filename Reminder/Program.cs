using Reminder_desktop_application;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string folder = Environment.UserName;
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\"+folder);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainAuthoriz());
        }
    }
}
