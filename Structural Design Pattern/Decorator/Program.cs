using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFood objPizza1 = new Pizza();
            objPizza1.Prepare();

            IFood objPizza2 = new OnionPizza(objPizza1);
            objPizza2.Prepare();

            IFood objPizza3 = new CapsicumPizza(new TomatoPizza(new OnionPizza(objPizza1)));
            objPizza3.Prepare();
        }
    }
}
