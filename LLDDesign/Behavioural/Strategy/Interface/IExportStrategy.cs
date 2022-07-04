using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Behavioural.Strategy.Interface
{
    public interface IExportStrategy
    {
        void Export(Order order);
    }
}
