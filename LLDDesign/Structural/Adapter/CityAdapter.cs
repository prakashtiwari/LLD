using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDDesign.Structural.Adapter
{
    public class CityAdapter : ICityAdapter
    {
        public City GetCity()
        {
            ExternalSystem externalSystem = new ExternalSystem();
            CityFromExternalSystem extcity = externalSystem.GetCity();
            City city = new City( extcity.Name + "-" + extcity.NickName,
                 extcity.Inhabitants);
            return city;

            
        }
    }
}
