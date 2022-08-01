using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Creational
{
    public class FurnitureItem
    {
        public string  Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public FurnitureItem(string Name, double Width, double Height, double Price, double weight)
        {
            this.Name = Name;
            this.Weight = weight;
            this.Width = Width;
            this.Height = Height;
            this.Price = Price;
        }
    }
}
