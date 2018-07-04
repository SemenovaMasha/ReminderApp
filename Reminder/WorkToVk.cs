using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace Reminder_desktop_application
{
    class WorkToVk
    {
        public string token;
        public string userId;
        public string keyWord;
        private VkApi vk = new VkApi();
        TaskServiceDB contextDB;
        UserSettingsModel model;
        ReminderContext context;

        public bool loginAuthorization(string login, string password)
        {
            context = new ReminderContext();
                contextDB = new TaskServiceDB();
            model = contextDB.getUserSettings();
            try
            {
                vk.Authorize(new ApiAuthParams
                {
                    ApplicationId = 6619305,
                    Login = login,
                    Password = password,
                    Settings = VkNet.Enums.Filters.Settings.All | VkNet.Enums.Filters.Settings.Offline //Не ори, я правил только тут
                });
                token = vk.Token;
                userId = vk.UserId.ToString();

                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void tokenAuthorization(string tokken)
        {
            try
            {
                vk.Authorize(new ApiAuthParams
                {
                    AccessToken = tokken
                });
            }
            catch (Exception ex)
            {

            }
        }
        
        string spisok = "";
        TaskServiceDB service;
        public void start(string tokken, string userId, string keyWord, TaskServiceDB service)
        {
          

            date = DateTime.Now;
            this.token = tokken;
            this.userId = userId;
            this.keyWord = keyWord.ToLower();
            this.service = service;

            //var list = service.getDailyTasks(DateTime.Now);
            //list = list.Where(c => c.next_date > DateTime.Now).ToList();

            //foreach (TaskModel word in list)
            //{
            //    spisok += word.text + "\n";
            //}

            //if (spisok == "")
            //{
            //    spisok = "Напоминаний на сегодня больше нет.";
            //}

            tokenAuthorization(token);

            //LastMessage = vk.Messages.Get(new MessagesGetParams
            //{
            //    Count = 1
            //}).Messages[0];

            Thread mythread = new Thread(tamer);

            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            mythread.Start();
        }

        System.Timers.Timer aTimer = new System.Timers.Timer(1000);

        DateTime date;
        VkNet.Model.Message LastMessage = null;
        VkNet.Model.Message CurrentMessage = null;
     //   int count;
        bool send;

        private void tamer()
        {
            aTimer.Elapsed += OnTimedEvent;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
            {

            LastMessage = new Message();
            LastMessage.Body = "";
            Console.WriteLine(date);
            send = false;
            try
            {
                contextDB = new TaskServiceDB();
                model = contextDB.getUserSettings();
                this.keyWord = model.secretWord;
                CurrentMessage = vk.Messages.Get(new MessagesGetParams
                {
                    Count = 1
                }).Messages[0];
                //LastMessage = CurrentMessage;

                //long id = Convert.ToInt64(CurrentMessage.UserId);
                
                if (CurrentMessage.UserId == Convert.ToInt64(model.vkUser) && 
                    //&&!CurrentMessage.Date.Equals(LastMessage.Date) && 
                    CurrentMessage.Body != LastMessage.Body
                    )
                {

                    if (CurrentMessage.Body.ToLower().Equals(keyWord.ToLower() + "#"))
                    {

                        var list = service.getDailyTasks(DateTime.Now);
                        list = list.Where(c => c.next_date > DateTime.Now).ToList();

                        spisok = "";
                        foreach (TaskModel word in list)
                        {
                            spisok += word.text + "\n";
                        }

                        if (spisok == "")
                        {
                            spisok = "Напоминаний на сегодня больше нет.";
                        }

                        SendMessage(Convert.ToInt64(userId), spisok);
                        //    count--;
                        LastMessage.Body = spisok;

                       // CurrentMessage.Body = spisok;
                    }
                }
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SendMessage(long ID, string Body)
        {

            try
            {
                if (!send)
                {
                    vk.Messages.Send(new MessagesSendParams
                    {
                        UserId = ID,
                        Message = Body,
                    });
                    send = true;
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }
    }
}