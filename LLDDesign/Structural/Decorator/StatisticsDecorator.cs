using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Decorator
{
    public class StatisticsDecorator: MailServiceDecorator
    {
        public StatisticsDecorator(IMailService mailService) : base(mailService)
        { 
        
        }
        public override void SendMail()
        {
            Console.WriteLine("Collecting statistics on "+typeof(StatisticsDecorator));
            base.SendMail();
        }
    }
}
