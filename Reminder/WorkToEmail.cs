using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_desktop_application
{
    class WorkToEmail
    {
        /// <summary>
        /// Метод для отправки почты на известный адрес
        /// </summary>
        /// <param name="Message"></param>
        public void Send(string recipientEmail, string message)
        { 
            SmtpClient smtp = new SmtpClient("smtp.mail.ru");
            smtp.Credentials = new NetworkCredential("zametki_and_napominaniya@inbox.ru", "cewgondyoSwesp7");
            smtp.EnableSsl = true;

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("zametki_and_napominaniya@inbox.ru", "Blocknote");
            // кому отправляем
            MailAddress to = new MailAddress(recipientEmail);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to)
            {
                // тема письма
                Subject = "Оповещение от Blocknote",
                // текст письма
                Body = message,
                // письмо представляет код html
                IsBodyHtml = true
            };
            try
            {
                smtp.Send(m);
            }
            catch(Exception ex) {
                int n;
            }
        }
    }
}
