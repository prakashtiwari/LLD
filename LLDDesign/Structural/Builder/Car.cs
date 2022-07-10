using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Builder
{
    public class Car
    {
        public List<string> parts = new List<string>();
        string carType;
        public Car(string carType)
        {
            this.carType = carType;
        }
        public void AddPart(string part)
        {
            parts.Add(part);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var part in parts)
            {
                sb.Append($"Car is of type {carType} has parts {part}");
            
            }
            return sb.ToString();
        }

    }
}
