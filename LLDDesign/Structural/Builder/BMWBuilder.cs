using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Builder
{
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        { }
        public override void BuildEngine()
        {
            car.AddPart("A fancy V8 engine!");
        }

        public override void BuildFrame()
        {
            car.AddPart("5 door with metallic finish!");
        }
    }
}
