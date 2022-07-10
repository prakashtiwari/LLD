using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Builder
{
    public class MiniCooperBuilder : CarBuilder
    {
        public MiniCooperBuilder() : base("Minicooper")
        { 
        
        }
        public override void BuildEngine()
        {
            car.AddPart("Not a V8");
        }

        public override void BuildFrame()
        {
            car.AddPart("3 door with stripes!");
        }
    }
}
