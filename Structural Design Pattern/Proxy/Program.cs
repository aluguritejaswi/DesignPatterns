using Proxy;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Client code
class Program
{
    static void Main()
    {
        IImage image1 = new RealImage("example1.jpg");
        // Image will be loaded from disk and displayed
        image1.Display();
        // Image will be displayed without loading from disk
        image1.Display();


        IImage image2 = new ProxyImage("example2.jpg");
        // Image will be loaded from disk and displayed
        image2.Display();
        // Image will be displayed without loading from disk
        image2.Display();
    }
}

