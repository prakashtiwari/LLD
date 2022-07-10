using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Builder
{
    public abstract class CarBuilder
    {
        public Car car { get; set; }
        public CarBuilder(string carType)
        {
            car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();

    }
    
}
