using System.Net;
using System.Net.Mail;

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
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("zametkiandnapominaniya@gmail.com", "cewgondyoSwesp7");
                smtp.EnableSsl = true;

                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("zametkiandnapominaniya@gmail.com", "Blocknote");
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
            
                smtp.Send(m);
            }
            catch { }
        }
    }
}
