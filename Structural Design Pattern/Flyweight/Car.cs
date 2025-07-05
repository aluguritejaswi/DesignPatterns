using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface ICar
    {
        string Color { get; }
        string Engine { get; }

        void SetLocation(decimal latitude, decimal longitude);
    }
    class BMWCar : ICar
    {
        public string Color { get; private set; }
        public string Engine { get; private set; }
        public BMWCar(string iColor, string iEngine)
        {
            Color = iColor;
            Engine = iEngine;
        }

        public void SetLocation(decimal latitude, decimal longitude)
        {
            Console.WriteLine($"Current location of BMW {Color} {Engine} car is  lat: {latitude}, lon: {longitude}");
        }
    }

    class AudiCar : ICar
    {
        public string Color { get; private set; }
        public string Engine { get; private set; }
        public AudiCar(string iColor, string iEngine)
        {
            Color = iColor;
            Engine = iEngine;
        }

        public void SetLocation(decimal latitude, decimal longitude)
        {
            Console.WriteLine($"Current location of Audi {Color} {Engine} car is  lat: {latitude}, lon: {longitude}");
        }
    }
}
