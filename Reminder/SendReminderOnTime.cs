using System;
using System.Collections.Generic;

namespace Reminder_desktop_application
{
    class SendReminderOnTime
    {
        TaskServiceDB context;
        public List<TaskModel> vs = new List<TaskModel>();
        WorkToVk vk = new WorkToVk();
        WorkToEmail mail = new WorkToEmail();
        UserSettingsModel user;

        public void start(string text)
        {
            context = new TaskServiceDB();
           user  = context.getUserSettings();

            if (user.vkMessageFlag)
                    {
                        vk.tokenAuthorization(context.getToken());
                        vk.SendMessage(Convert.ToInt64(user.vkUser), text);
                    }

                    if (user.mailMessageFlag)
                    {
                        mail.Send(user.mailUserName, text);
                    }
                }
            }
        }