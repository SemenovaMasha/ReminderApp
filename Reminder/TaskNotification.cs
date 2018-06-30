using Reminder_desktop_application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class TaskNotification : MetroFramework.Forms.MetroForm
    {
        public TaskModel taskToNotify;

        public TaskNotification(TaskModel tasktonotify)
        {
            InitializeComponent();
            taskToNotify = tasktonotify;
            LoadTask();
        }

        public void LoadTask()
        {
            notificationBox.Text = taskToNotify.text;
            SendReminderOnTime send = new SendReminderOnTime();
            send.start(taskToNotify.text);
        }

        private void doneLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
