using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Adapter
{
    public class City
    {
        public string FullName { get; set; }
        public int Inhabitants { get; set; }
        public City(string fullName, int inhabitants)
        {

            this.FullName = fullName;
            this.Inhabitants = inhabitants;
        }
    }
}
