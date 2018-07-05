using Reminder;
using System;
using System.Windows.Forms;

namespace Reminder_desktop_application
{
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        TaskServiceDB context;

        public SettingsForm(TaskServiceDB context)
        {
            this.context = context;
            UserSettingsModel m = context.getUserSettings();
            InitializeComponent();
            keyWordTbx.TextAlign = HorizontalAlignment.Right;

            vkNotificationChbx.Checked = m.vkMessageFlag;
            mailNotificationChbx.Checked = m.mailMessageFlag;
            mailLoginTbx.Text = m.mailUserName;
            keyWordTbx.Text = m.secretWord;
            fontSizeBx.Value = m.fontSize;
            if (m.vkToken is null || m.vkToken == "")
            {
                connectVKBtn.Text = "Подключить Вконтакте";
            }
            else
            {
                connectVKBtn.Text = "Отключить Вконтакте";
            }

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            WaitForm pleaseWait = new WaitForm();
            pleaseWait.Show();
            Application.DoEvents();

            UserSettingsModel model = context.getUserSettings();

            model.vkMessageFlag = vkNotificationChbx.Checked;
            model.mailMessageFlag = mailNotificationChbx.Checked;
            model.mailUserName = mailLoginTbx.Text;
            model.secretWord = keyWordTbx.Text.ToLower();
            model.fontSize = Convert.ToInt32(fontSizeBx.Value);

            context.editSettings(model);
            pleaseWait.Close();
            this.Close();
        }

        private void connectVKBtn_Click(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(mailLoginTbx, "На введенный адрес будут приходить уведомления");
            t.SetToolTip(keyWordTbx, "Ключевое слово, написав которое в сообщении ВК, вы получите список ваших уведомлений на сегодня.");
            
            var m = context.getUserSettings();
            if (connectVKBtn.Text == "Отключить Вконтакте")
            {
                context.tokenToNull();
                vkNotificationChbx.Checked = false;
                connectVKBtn.Text = "Подключить Вконтакте";
            }
            else
            {
                AuthorizationForm form = new AuthorizationForm(context);
                form.ShowDialog();
                if (form.result)
                {
                    connectVKBtn.Text = "Отключить Вконтакте";
                }
            }
            this.connectVKBtn.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormMainAuthoriz formMainAuthoriz = new FormMainAuthoriz();
            formMainAuthoriz.Text = "Редактирование";
            formMainAuthoriz.IsEdit = true;
            formMainAuthoriz.ShowDialog();
            
        }

        private void cancelLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(mailLoginTbx, "На этот адрес будут приходить уведомления");
            t.SetToolTip(keyWordTbx, "Ключевое слово для доступа в вашим напоминаниям через ВК");
            t.SetToolTip(fontSizeBx, "Размер шрифта заметок/напоминаний");
        }
    }
}
