using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Decorator
{
    public class OnPrimMAilService:IMailService
    {
        public void SendMail()
        {
            Console.WriteLine("Sending mail through on prim mail service!");
        }

        
    }
}
