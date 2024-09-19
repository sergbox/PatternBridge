using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendingLettersByMail.UsersClasses
{
    public class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body) 
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("sergbox@gmail.com","Илюшко Сергей Алексеевич");
            EmailPassword = "11111";
            Port = 587;
        }
    }
}
