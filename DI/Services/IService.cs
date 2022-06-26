using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public interface IService
    {

        void InjectService();
      

    }

    public delegate IService ServiceResolver(string key);
}
