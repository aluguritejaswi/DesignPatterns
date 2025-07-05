using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesign
{
  class Program
  {
    static void Main(string[] args)
    {
      IVehicleFactory hondaFactory = new HondaFactory();
      VehicleClient hondaSports = new VehicleClient(hondaFactory, VehicleType.Sports);
      VehicleClient hondaRegular = new VehicleClient(hondaFactory, VehicleType.Regular);

      Console.WriteLine("**************** Honda Bikes*****************");
      Console.WriteLine(hondaSports.GetBikeName("CBZ"));
      Console.WriteLine(hondaRegular.GetBikeName("Shine"));

      Console.WriteLine("**************** Honda Scooters*****************");
      Console.WriteLine(hondaSports.GetScooterName("Actia"));
      Console.WriteLine(hondaRegular.GetScooterName("Eterno"));

      Console.ReadLine();
    }
  }
}
