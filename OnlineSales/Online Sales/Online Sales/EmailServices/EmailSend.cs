using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.EmailServices
{
    public class EmailSend
    {
        public void Send(string email, string subject, string htmlMessage)
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Ruslan Qelenderli", "rqelenderli7@gmail.com"));
            message.To.Add(new MailboxAddress("Client", email));
            message.Subject = subject;
            message.Body = new TextPart()
            {
                Text=htmlMessage
            };
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("rqelenderli7@gmail.com", "@d@dbal+");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
