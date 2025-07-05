using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder objProductBuilder = new ProductBuilder();
           
            Product objProduct = objProductBuilder.SetColor("white").SetName("abc").Build();

            Console.WriteLine("Product Name: " + objProduct.Name + "\nProduct Color: " + objProduct.Color);

        }
    }
}
