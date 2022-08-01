using LLDDesign.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Creational.Builder
{
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private IEnumerable<FurnitureItem> _items;
        public DailyReportBuilder(IEnumerable<FurnitureItem> furnitureItems)
        {
          
            Reset();
            _items = furnitureItems;
        }
        public void Reset()
        {
            _report = new InventoryReport();
        }
        public void AddDimensions()
        {
            _report.DimensionSection = string.Join(Environment.NewLine, _items.Select(product =>
                $"Product: {product.Name} \nPrice: {product.Price} \nHeight :{product.Height} \nWidth {product.Width}"
               ));
            
        }

        public void AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report generated on {dateTime.ToLongTimeString()}";
            
        }

        public void AddTitles()
        {
            _report.TitleSection = "-----------------Daily Inventory Report------\n\n";
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport finalReport = _report;
            Reset();
            return finalReport;
        }
    }
}
