﻿using Reminder;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            using (ReminderContext db = new ReminderContext())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Reminder(db));
            }
        }
    }
}
