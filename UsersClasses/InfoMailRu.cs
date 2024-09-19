using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendingLettersByMail.UsersClasses
{
    public class InfoMailRu : InfoEmail
    {
        public InfoMailRu(StringPair emailAdressTo, string subject, string body)
            : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.com";
            EmailAdressFrom = new StringPair("sergbox@mail.com", "Илюшко Сергей Алексеевич");
            EmailPassword = "11111";
            Port = 587;
        }
    }
}
