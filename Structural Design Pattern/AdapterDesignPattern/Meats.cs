using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// The new Meats class, which represents details
    /// about a particular kind of meat.
    /// </summary>
    public class Meats
    {
        protected string MeatName;
        protected double SafeCookingTemperatureFahrenheit;
        protected double SafeCookingTemperatureCelsius;
        protected double CaloriesPerOunce;
        protected double CaloriesPerGram;
        protected double ProteinPerOunce;
        protected double ProteinPerGram;

        public Meats(string meatName)
        {
            this.MeatName = meatName;
        }

        public virtual void LoadData()
        {
            Console.WriteLine($"\n Meat Name:  { MeatName}");
        }
    }
}
