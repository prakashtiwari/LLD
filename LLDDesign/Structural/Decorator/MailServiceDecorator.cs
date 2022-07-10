using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Decorator
{
    public abstract class MailServiceDecorator
    {
        IMailService mailService;

        public MailServiceDecorator(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public virtual void SendMail()
        {

            mailService.SendMail();
        }
    }
}
