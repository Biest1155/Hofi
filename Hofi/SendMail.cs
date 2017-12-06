using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;

namespace Hofi
{
       public class SendMail
    {
        MailMessage mail;
        private void sendmail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("hofi@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "Din vagt er registeret";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("Hofi@gmail.com", "hsgfitness");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Vagten registreret");
            }
            catch (Exception)
            {
                Console.WriteLine("Der skete en uventet fejl, mailen er ikke sendt");
            }
        }
    }
}
