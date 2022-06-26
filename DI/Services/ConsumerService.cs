using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{


    public class ConsumerService
    {
        public readonly IService service;

        public ConsumerService(ServiceResolver serviceResolver)
        {
            this.service = serviceResolver("A");
            service.InjectService();

            this.service = serviceResolver("B");
            service.InjectService();
        }
    }
}
