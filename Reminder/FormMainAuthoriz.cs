using Reminder;
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

namespace Reminder
{
    public partial class FormMainAuthoriz : MetroFramework.Forms.MetroForm
    {
        
        TaskServiceDB context;
        Reminder_desktop_application.Reminder r = new Reminder_desktop_application.Reminder();

        public FormMainAuthoriz()
        {
            this.Text = "Авторизация";
            InitializeComponent();
            r.Enabled = false;
        }

        UserSettingsModel user = new UserSettingsModel();
        string login;
        string password;
        bool flagIsFirst;

        private void FormMainAuthoriz_Open()
        {
            flagIsFirst = IsFirstAutoriz();
        }

        public bool IsFirstAutoriz()
        {
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
                this.Close();
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
                user.login = loginTbx.Text;
                user.password = passwordTbx.Text;
            }

            autoriz(login, password);
        }
    }
}
