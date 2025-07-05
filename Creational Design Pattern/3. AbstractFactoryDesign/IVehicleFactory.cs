using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  public interface IVehicleFactory
  {
    IBike GetBike(VehicleType vehicleType);
    IScooter GetScooter(VehicleType vehicleType);
  }

  public enum VehicleType
  {
    Sports,
    Regular
  }
}
