using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Decorator
{
    public class MessageDatabaseDecorator:MailServiceDecorator
    {
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
        { 
        }
        public override void SendMail()
        {
            Console.WriteLine("Save mail statistic in the database!");
            base.SendMail();
        }
    }
}
