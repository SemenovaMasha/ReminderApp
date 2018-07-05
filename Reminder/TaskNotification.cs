using Reminder.Properties;
using System;
using System.Media;

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
            SoundPlayer soundPlayer = new SoundPlayer(Resources.notify);
            soundPlayer.Load();
            soundPlayer.PlaySync();
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
