using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class ServiceA : IService
    {
        public void InjectService()
        {
            Console.WriteLine("ServiceA injected");
        }
    }
}
