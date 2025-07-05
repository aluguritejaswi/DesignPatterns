using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  class RegularScooter : IScooter
  {
    public string GetScooterName(string name)
    {
      return "Regular Scooter " + name;
    }
  }
}
