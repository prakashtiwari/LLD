using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Behavioural.Strategy.Interface
{
    public class Order
    {
        public int ItemCount { get; set; }
        public string Name { get; set; }
        IExportStrategy exportStrategy;
        public Order(int Count, string Name)
        {
            ItemCount = Count;
            this.Name = Name;
        }
        public void Export(IExportStrategy strategy)
        {
            exportStrategy = strategy;
            exportStrategy.Export(this);
        }
    }
}
