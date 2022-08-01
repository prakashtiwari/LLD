using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Creational.Interface
{
    public interface IFurnitureInventoryBuilder
    {
        void AddTitles();
        void AddDimensions();
        void AddLogistics(DateTime dateTime);
        InventoryReport GetDailyReport();
    }
}
