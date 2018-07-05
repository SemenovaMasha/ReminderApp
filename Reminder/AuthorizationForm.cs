using Reminder;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class AuthorizationForm : MetroFramework.Forms.MetroForm
    {
        TaskServiceDB context;
        public AuthorizationForm(TaskServiceDB context)
        {
            this.Text = "Авторизация VK";
            this.context = context;
            InitializeComponent();

        }
        

        UserSettingsModel model;
        public bool result;

        private void okBtn_Click(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();
  
            model = context.getUserSettings();
            WorkToVk workVk = new WorkToVk();
            
            if (!workVk.loginAuthorization(loginTbx.Text, passwordTbx.Text))
            {
            
                passwordTbx.Text = null;
                result = false;
                pleaseWait.Close();
                MessageBox.Show("Авторизация не удалась. Попробуйте снова или обратитесь на сайт vk.com для восстановления данных.");
            }
            else
            {
                model.vkToken = Crypter.Encrypt(workVk.token);
                model.vkUser = workVk.userId.ToString();
                context.editToken(workVk.token, workVk.userId);
                workVk.start(workVk.token, workVk.userId, model.secretWord, context);
                result = true;
                pleaseWait.Close();
                this.Close();
            }
        }

        private void passwordTbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okBtn_Click(null, null);
        }
        
    }
}
