using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Sales.EmailServices
{
   public  interface IEmailSender
    {
        void SendEmail(string email, string subject, string htmlMessage);
        void SendEmail2(string email, string subject, string htmlMessage);
    }
}
