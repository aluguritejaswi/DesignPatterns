using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted
            Meats unknown = new Meats("beef");
            unknown.LoadData();

            // Adapted
            MeatDetails beef = new MeatDetails("beef");
            beef.LoadData();

            MeatDetails chicken = new MeatDetails("chicken");
            chicken.LoadData();

            MeatDetails turkey = new MeatDetails("turkey");
            turkey.LoadData();
        }
    }
}
