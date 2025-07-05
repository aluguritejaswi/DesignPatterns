using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Client code
    class Program
    {
        static void Main()
        {
            ComputerFacade computer = new ComputerFacade();
            computer.Start(); // Simplified interaction
        }
    }
}
