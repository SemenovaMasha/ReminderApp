using Reminder;
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
    public partial class SettingsForm : MetroFramework.Forms.MetroForm
    {
        TaskServiceDB context;
        bool hasToken;
        public SettingsForm(TaskServiceDB context)
        {
            this.context = context;
            InitializeComponent();

            UserSettingsModel m = context.getUserSettings();

            vkNotificationChbx.Checked = m.vkMessageFlag;
            mailNotificationChbx.Checked = m.mailMessageFlag;
            mailLoginTbx.Text = m.mailUserName;
            fontSizeBx.Value = m.fontSize;
            hasToken = m.vkToken != "";
            connectVKBtn.Text = hasToken ? "Отключить Вконтакте" : "Подключить Вконтакте";
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            UserSettingsModel model = new UserSettingsModel
            {
               // vkToken = vkNotificationChbx.Checked?   :"",
                vkMessageFlag = vkNotificationChbx.Checked,
                mailMessageFlag = mailNotificationChbx.Checked,
                mailUserName = mailLoginTbx.Text,
                fontSize = Convert.ToInt32(fontSizeBx.Value)
            };
            context.editSettings(model);
        }

        private void connectVKBtn_Click(object sender, EventArgs e)
        {
            if (hasToken)
            {
                context.editToken("","");
            }
            else
            {
                AuthorizationForm form = new AuthorizationForm(context);
                form.ShowDialog();

                form.getToken();
            }
        }
    }
}
