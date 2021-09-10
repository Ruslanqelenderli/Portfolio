using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MimeKit;

namespace Online_Sales.EmailServices
{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _username;
        private string _password;
        public SmtpEmailSender(string host, int port, bool enableSSL, string username, string password)
        {
            this._host = host;
            this._port = port;
            this._enableSSL = enableSSL;
            this._username = username;
            this._password = password;
        }
        public void SendEmail(string email, string subject, string htmlMessage)
        {

            //var client = new SmtpClient(this._host, this._port)
            //{
            //    Credentials = new NetworkCredential(_username, _password),
            //    EnableSsl = this._enableSSL
            //};
            //var client = new SmtpClient(this._host, this._port);
            //client.UseDefaultCredentials = false;
            //client.Credentials = new NetworkCredential(_username, _password);
            //client.EnableSsl = this._enableSSL;
            //client.Send(
            //    new MailMessage(this._username, email, subject, htmlMessage)
            //    {
            //        IsBodyHtml = true
            //    }
            //);


            
        }



        public void SendEmail2(string email, string subject, string htmlMessage)
        {
            //MimeMessage message = new MimeMessage();

            //message.From.Add(new MailboxAddress("Ruslan Qelenderli", "rqelenderli7@gmail.com"));
            //message.To.Add(new MailboxAddress("Client", email));
            //message.Subject = subject;
            //message.Body = new TextPart()
            //{
            //    Text = htmlMessage
            //};
            //MailKit.Net.Smtp.SmtpClient client = new SmtpClient();
                
            //    client.Connect(_host,_port, _enableSSL);
            //    client.Authenticate("rqelenderli7@gmail.com", "");
            //    client.Send(message);
            //    client.Disconnect(true);
            
            


        }
    }
}
