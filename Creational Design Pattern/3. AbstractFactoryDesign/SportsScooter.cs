using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  class SportsScooter : IScooter
  {
    public string GetScooterName(string name)
    {
      return "Sports Scooter " + name;
    }
  }
}
