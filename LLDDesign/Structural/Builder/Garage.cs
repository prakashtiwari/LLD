using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Builder
{
   public class Garage
    {
        CarBuilder buildr;
        public Garage()
        { 
        }
        public void Construct(CarBuilder carBuilder)
        {
            buildr = carBuilder;
            buildr.BuildEngine();
            buildr.BuildFrame();
        }
        public void Show()
        {
            Console.WriteLine(buildr?.car.ToString());
        }
    }
}
