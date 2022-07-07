using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Adapter
{
    public class CityFromExternalSystem
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Inhabitants { get; set; }
        public CityFromExternalSystem(string name, string nickname, int inhabitants)

        {
            this.Name = name;
            this.NickName = nickname;
            this.Inhabitants = inhabitants;
        }
    }
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Bangalore","Garden city",50000);
        }
    }
}
