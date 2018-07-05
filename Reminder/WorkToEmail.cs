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
                
                MailAddress from = new MailAddress("zametkiandnapominaniya@gmail.com", "Blocknote");
                MailAddress to = new MailAddress(recipientEmail);
                MailMessage m = new MailMessage(from, to)
                {
                    Subject = "Оповещение от Blocknote",
                    Body = message,
                    IsBodyHtml = true
                };
            
                smtp.Send(m);
            }
            catch { }
        }
    }
}
