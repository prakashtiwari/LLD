using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Creational
{
   public class InventoryReport
    {
        public string TitleSection { get; set; }
        public string DimensionSection { get; set; }
        public string LogisticsSection { get; set; }
        public string Debug()
        {
            return new StringBuilder().AppendLine(TitleSection).AppendLine(DimensionSection).AppendLine(LogisticsSection).ToString();
        }
    }
}
