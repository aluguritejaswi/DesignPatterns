using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  internal class RegularBike : IBike
  {
    public string GetBikeName(string name)
    {
      return "Regular Bike " + name;
    }
  }
}
