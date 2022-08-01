using LLDDesign.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Creational.Builder
{
    /// <summary>
    /// This class can have any number of method to build any kind of report.
    /// </summary>
   public class InventoryBuildDirector
    {
        IFurnitureInventoryBuilder _furnitureInventoryBuilder;
        public InventoryBuildDirector(IFurnitureInventoryBuilder furnitureInventoryBuilder)
        {
            _furnitureInventoryBuilder = furnitureInventoryBuilder;

        }
        public void BuildCompleteReport()
        {
            _furnitureInventoryBuilder.AddTitles();
            _furnitureInventoryBuilder.AddDimensions();
            _furnitureInventoryBuilder.AddLogistics(DateTime.Now);

        }

    }
}
