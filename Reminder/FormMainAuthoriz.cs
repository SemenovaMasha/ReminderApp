using Reminder;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class FormMainAuthoriz : MetroFramework.Forms.MetroForm
    {
        
        TaskServiceDB context;

        UserSettingsModel user;
        string login;
        string password;
        bool flagIsFirst;
        public bool IsEdit;

        public FormMainAuthoriz()
        {
            this.Text = "Авторизация";
            InitializeComponent();
            
        }

        WaitForm pleaseWait = new WaitForm();

        public bool IsFirstAutoriz()
        {
            context = new TaskServiceDB();

            context.createSettingsIfNotExists();
            user = context.getUserSettings();
            login = user.login;
            password = user.password;

            if (login == "x" && password == "x")
            {
                pleaseWait.Close();
                MessageBox.Show("Вы зашли впервые, введите данные для доступа к приложениию в дальнейшем.");
                metroButton2.Visible = true;
                IsEdit = false;
                return true;
            }
            else
            {
                IsEdit = false;
                return false;
            }
        }

        public void autoriz(string login, string password)
        {

            if (user.login == login && user.password == password)
            {
                this.Hide();

                WaitForm pleaseWait = new WaitForm();
                pleaseWait.Show();
                Application.DoEvents();
                
                Reminder reminder = new Reminder();
                pleaseWait.Close();
                reminder.Show();

                reminder.Activate();
                reminder.Focus();
                reminder.BringToFront();
            }
            else
            {
                pleaseWait.Close();
                MessageBox.Show("Авторизация не удалась, введите данные верно или обратитесь в тех.поддержку.");
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();

            context = new TaskServiceDB();
            if (IsEdit)
            {
                try
                {
                    if (loginTbx.Text.Trim() != "" && passwordTbx.Text.Trim() != "")
                    {
                        context.auth(loginTbx.Text, passwordTbx.Text);
                        pleaseWait.Close();
                        MessageBox.Show("Сохранение прошло успешно.");
                        this.Close();
                    }
                    else
                    {
                        pleaseWait.Close();
                        MessageBox.Show("Поля не могут быть пустыми.");
                    }
                }
                catch
                {
                    pleaseWait.Close();
                    MessageBox.Show("Сохранение не удалось.");
                    
                }
            }
            else
            {
                if (flagIsFirst)
                {
                    context = new TaskServiceDB();
                    try
                    {
                        user = context.getUserSettings();
                    }
                    catch
                    {
                        context.createSettingsIfNotExists();
                    }

                    if (loginTbx.Text.Trim() != "" && passwordTbx.Text.Trim() != "")
                    {
                        context.auth(loginTbx.Text, passwordTbx.Text);
                        pleaseWait.Close();
                        MessageBox.Show("Сохранение прошло успешно.");
                       
                        this.Hide();
                        Reminder reminder = new Reminder();
                        reminder.Show();

                        reminder.Activate();
                        reminder.Focus();
                        reminder.BringToFront();
                    }
                    else
                    {
                        pleaseWait.Close();
                        MessageBox.Show("Поля не могут быть пустыми.");
                     
                    }
                }
                else
                {
                    if (loginTbx.Text.Trim() != "" && passwordTbx.Text.Trim() != "")
                    {
                        autoriz(loginTbx.Text, passwordTbx.Text);
                    }
                    else
                    {
                        pleaseWait.Close();
                        MessageBox.Show("Поля не могут быть пустыми.");

                    }
                }
                pleaseWait.Close();
            }
            pleaseWait.Close();
        }

        private void FormMainAuthoriz_Load(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();

            if (!IsEdit)
            {
                if(!(flagIsFirst = IsFirstAutoriz()))
                {
                    if (user.login == "empty" && user.password == "empty")
                    {
                        this.WindowState = FormWindowState.Minimized;
                        ShowInTaskbar = false;
                        Reminder reminder = new Reminder();
                        pleaseWait.Close();
                        reminder.Show();

                        reminder.Activate();
                        reminder.Focus();
                        reminder.BringToFront();
                    }
                }
                else
                {
                    pleaseWait.Close();
                    metroButton2.Visible = true;
                }
            }
            else
            {
                pleaseWait.Close();
                metroButton2.Visible = true;
            }
            pleaseWait.Close();

            this.Activate();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();
            TaskServiceDB context = new TaskServiceDB();
            UserSettingsModel model = context.getUserSettings();
            WorkToVk vk = new WorkToVk();
            try
            {
                vk.tokenAuthorization(context.getToken());
                vk.SendMessage(28970351, "Здравствуйте, я забыл(а) свои данные для входа в программу. Пожалуйста, свяжитесь со мной.");
                pleaseWait.Close();
                MessageBox.Show("Сообщение в техподдержку отправлено, с вами свяжутся в ближайшее время.");
            }
            catch
            {
                pleaseWait.Close();
                MessageBox.Show("Вы не авторизованы ВК. Зайдите и нажмите на кнопку 'Я забыла(а) пароль' еще раз.");

                AuthorizationForm form = new AuthorizationForm(context);
                form.ShowDialog();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();

            context = new TaskServiceDB();
            context.auth("empty", "empty");
            pleaseWait.Close();
            MessageBox.Show("При входе авторизация больше не потребуется. Если вы хотите установить защиту, вы можете сделать это в настройках программы.");
            
            this.Hide();
            if (!IsEdit)
            {
                Reminder reminder = new Reminder();
                pleaseWait.Close();
                reminder.Show();

                reminder.Activate();
                reminder.Focus();
                reminder.BringToFront();
            }

        }

        private void passwordTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okBtn_Click(null, null);
        }
    }
}
