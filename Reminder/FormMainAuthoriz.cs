﻿using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class FormMainAuthoriz : MetroFramework.Forms.MetroForm
    {
        
        TaskServiceDB context;
        //Reminder_desktop_application.Reminder r = new Reminder_desktop_application.Reminder();

        UserSettingsModel user;
        string login;
        string password;
        bool flagIsFirst;
        ReminderContext con;

        public FormMainAuthoriz()
        {
            this.Text = "Авторизация";
            InitializeComponent();
            //r.Enabled = false;

            //если надо очистить данные логина/пароля снять комментирование и закомментировать снова
            //context = new TaskServiceDB();
            //user = context.getUserSettings();
            //context.auth("x", "x");
        }


        public bool IsFirstAutoriz()
        {
            context = new TaskServiceDB();
            user = context.getUserSettings();
            login = user.login;
            password = user.password;

            if (login == "x" && password == "x")
            {
                MessageBox.Show("Вы зашли впервые, введите данные для доступа к приложениию в дальнейшем.");
                return true;
            }
            else
            {
                return false;
            }

        }

        public void autoriz(string login, string password)
        {
            if (loginTbx.Text == login && passwordTbx.Text == password)
            {
                MessageBox.Show("Авторизация прошла успешно.");
                this.Hide();
                Reminder reminder = new Reminder();
                reminder.Show();
            }
            else
            {
                MessageBox.Show("Авторизация не удалась, введите данные верно или обратитесь в тех.поддержку.");
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (flagIsFirst)
            {
                context = new TaskServiceDB();
                user = context.getUserSettings();
                con = new ReminderContext();
                context.auth(loginTbx.Text, passwordTbx.Text);

                this.Hide();
                Reminder reminder = new Reminder();
                reminder.Show();
            }
            else
            {
                autoriz(login, password);
            }
        }

        private void FormMainAuthoriz_Load(object sender, EventArgs e)
        {
            flagIsFirst = IsFirstAutoriz();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TaskServiceDB context = new TaskServiceDB();
            UserSettingsModel model = context.getUserSettings();
            WorkToVk vk = new WorkToVk();
            try
            {
                vk.tokenAuthorization(context.getToken());
                vk.SendMessage(28970351, "Здравствуйте, я забыл(а) свои данные для входа в программу. Пожалуйста, свяжитесь со мной.");
                MessageBox.Show("Сообщение в техподдержку отправлено, с вами свяжутся в ближайшее время.");
            }
            catch
            {
                MessageBox.Show("Вы не авторизованы ВК. Зайдите и нажмите на кнопку 'Я забыла(а) пароль' еще раз.");
                AuthorizationForm form = new AuthorizationForm(context);
                form.ShowDialog();
            }
        }

        void AuthorizationForm_FormClosing(object sender, EventArgs e)
        {
            TaskServiceDB context = new TaskServiceDB();
            UserSettingsModel model = context.getUserSettings();
            WorkToVk vk = new WorkToVk();
            vk.tokenAuthorization(context.getToken());
            vk.SendMessage(28970351, "Здравствуйте, я забыл(а) свои данные для входа в программу. Пожалуйста, свяжитесь со мной.");
            MessageBox.Show("Сообщение в техподдержку отправлено, с вами свяжутся в ближайшее время.");
        }
    }
}