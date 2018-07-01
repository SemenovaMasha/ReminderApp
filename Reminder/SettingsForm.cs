﻿using Reminder_desktop_application;
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
        UserSettingsModel m;
        TaskServiceDB context;
       // bool hasToken;

        public SettingsForm(TaskServiceDB context)
        {
            this.context = context;
            m = context.getUserSettings();
            InitializeComponent();
            keyWordTbx.TextAlign = HorizontalAlignment.Right;

            vkNotificationChbx.Checked = m.vkMessageFlag;
            mailNotificationChbx.Checked = m.mailMessageFlag;
            mailLoginTbx.Text = m.mailUserName;
            keyWordTbx.Text = m.secretWord;
            fontSizeBx.Value = m.fontSize;
         //   hasToken = m.vkToken != "";
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
            //TaskServiceDB context = new TaskServiceDB();
            UserSettingsModel model = context.getUserSettings();

            model.vkMessageFlag = vkNotificationChbx.Checked;
            model.mailMessageFlag = mailNotificationChbx.Checked;
            model.mailUserName = mailLoginTbx.Text;
            model.secretWord = keyWordTbx.Text;
            model.fontSize = Convert.ToInt32(fontSizeBx.Value);

            context.editSettings(model);
            this.Close();
        }

        private void connectVKBtn_Click(object sender, EventArgs e)
        {
            m = context.getUserSettings();
            if (connectVKBtn.Text == "Отключить Вконтакте")
            {
                m.vkToken = null;
                m.vkUser = null;
                vkNotificationChbx.Checked = false;

                connectVKBtn.Text = "Подключить Вконтакте";
            }
            else
            {
                AuthorizationForm form = new AuthorizationForm(context);
                form.ShowDialog();

                // form.getToken();
                connectVKBtn.Text = "Отключить Вконтакте";
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
    }
}
