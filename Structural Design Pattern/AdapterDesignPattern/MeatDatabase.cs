using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// The legacy API must be converted to the new structure
    /// </summary>
    public class MeatDatabase
    {
        public float GetSafeCookingTemperature(string meat)
        {
            switch (meat)
            {
                case "beef":
                case "pork":
                    return 145f;
                case "chicken":
                case "turkey":
                    return 165f;
                default:
                    return 0.0f;
            }
        }

        public int GetCaloriesPerOunce(string meat)
        {
            switch (meat)
            {
                case "beef": return 71;
                case "pork": return 69;
                case "chicken": return 66;
                case "turkey": return 38;
                default: return 0;
            }
        }

        public double GetProteinPerOunce(string meat)
        {
            switch (meat)
            {
                case "beef": return 7.3;
                case "pork": return 7.6;
                case "chicken": return 8.6;
                case "turkey": return 8.5;
                default: return 0;
            }
        }
    }

    public enum TemperatureType
    {
        Faherenheit,
        Celsius
    }
}
