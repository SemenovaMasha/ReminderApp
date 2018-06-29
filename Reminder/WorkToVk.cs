using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace Reminder
{
    class WorkToVk
    {
        public string token;
        public string userId;
        private VkApi vk = new VkApi();

        public void loginAuthorization(string login, string password)
        {
            try
            {
                vk.Authorize(new ApiAuthParams
                {
                    ApplicationId = 6619305,
                    Login = login,
                    Password = password,
                    Settings = VkNet.Enums.Filters.Settings.All
            });
                //Timerr();
                token = vk.Token;
                userId = vk.UserId.ToString();
            }
            catch
            {
                //MessageBox.Show("Авторизация не удалась");
            }
        }
        private void tokenAuthorization(string tokken)
        {
            try { 
                vk.Authorize(new ApiAuthParams
                {
                    AccessToken = tokken
                });
                //Timerr();
                //return vk.Token;
            }
            catch
            {
                //MessageBox.Show("Авторизация не удалась");
                //return "";
            }
        }

        public void start(string tokken,string userId)
        {
            this.token = tokken;
            this.userId = userId;


            tokenAuthorization(token);
            
            LastMessage = vk.Messages.Get(new MessagesGetParams
            {
                Count = 1
            }).Messages[0];

            Timer aTimer = new System.Timers.Timer(2000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        VkNet.Model.Message LastMessage = null;
        VkNet.Model.Message CurrentMessage = null;

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                CurrentMessage = vk.Messages.Get(new MessagesGetParams
                {
                    Count = 1
                }).Messages[0];

                //MessageBox.Show(CurrentMessage.UserId+"!"+ CheckedUserID);

                if (
                    CurrentMessage.UserId == Convert.ToInt64(userId) &&
                    !CurrentMessage.Date.Equals(LastMessage.Date))
                {

                    if (CurrentMessage.Body.Equals("список#"))
                    {
                        SendMessage((long)(CurrentMessage.UserId), "списочек");
                    }

                    LastMessage = vk.Messages.Get(new MessagesGetParams
                    {
                        Count = 1
                    }).Messages[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void SendMessage(long ID, string Body)
        {
            vk.Messages.Send(new MessagesSendParams
            {
                UserId = ID,
                Message = Body
            });
        }
    }
}
