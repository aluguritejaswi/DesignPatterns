using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  class SportsBike : IBike
  {
    public string GetBikeName(string name)
    {
      return "Sports Bike " + name;
    }
  }
}
