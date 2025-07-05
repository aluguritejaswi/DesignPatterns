using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class CarManager
    {
        private readonly ICar _car;
        private decimal latitude = 0, longitude = 0;

        public CarManager(ICarFactory carFactory, string type)
        {
            _car = carFactory.GetCar(type);
        }

        public void SetLocation(decimal lat, decimal lon)
        {
            this.latitude = lat;
            this.longitude = lon;
            _car.SetLocation(latitude, longitude);
        }
    }
}
