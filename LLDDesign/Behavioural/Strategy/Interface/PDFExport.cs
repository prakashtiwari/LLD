using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Behavioural.Strategy.Interface
{
    public class PDFExport: IExportStrategy
    {
        public void Export(Order order)
        {

            Console.WriteLine("PDF Export");
        }
    }
}
