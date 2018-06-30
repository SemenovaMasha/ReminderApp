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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainAuthoriz());
        }
    }
}
