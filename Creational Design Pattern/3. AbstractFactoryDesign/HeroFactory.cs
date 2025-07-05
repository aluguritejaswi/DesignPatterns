using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  class HeroFactory : IVehicleFactory
  {
    public IBike GetBike(VehicleType type)
    {
      switch (type)
      {
        case VehicleType.Sports:
          return new SportsBike();
        case VehicleType.Regular:
          return new RegularBike();
        default:
          throw new Exception("InvalidType");
      }
    }

    public IScooter GetScooter(VehicleType type)
    {
      switch (type)
      {
        case VehicleType.Sports:
          return new SportsScooter();
        case VehicleType.Regular:
          return new RegularScooter();
        default:
          throw new Exception("InvalidType");
      }
    }
  }
}
