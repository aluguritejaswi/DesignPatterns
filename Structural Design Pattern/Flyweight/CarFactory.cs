using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface ICarFactory
    {
        ICar GetCar(string typeOfCar);
    }
    class CarFactory : ICarFactory
    {
        private readonly Dictionary<string, ICar> cars = new Dictionary<string, ICar>();
        public ICar GetCar(string typeOfCar)
        {
            if (cars.ContainsKey(typeOfCar)) return cars[typeOfCar];

            var car = CreateCar(typeOfCar);
            cars.Add(typeOfCar, car);
            return car;
        }

        private ICar CreateCar(string type)
        {
            switch (type)
            {
                case "BMW": return new BMWCar("Red", "V2");
                case "Audi": return new AudiCar("Blue", "V6");
                default: throw new NotImplementedException("Invalid.");
            }          
        }
    }
}
