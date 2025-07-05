using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  class Program
  {
    static void Main(string[] args)
    {
      // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
      // IComponent means the class that implements the IComponent Interface
      //Creating Leaf Objects or you can say child objects
      IComponent hardDisk = new Leaf( 2000, "Hard Disk");
      IComponent ram = new Leaf( 2000, "ram");
      IComponent cpu = new Leaf( 2000, "cpu");
      IComponent mouse = new Leaf( 2000, "mouse");
      IComponent keyboard = new Leaf( 2000, "keyboard");

      Composite motherBoard = new Composite("Mother Board");
      Composite cabinate = new Composite("Cabinate");
      Composite peripherals = new Composite("Peripherals");
      Composite computer = new Composite("Computer");

      motherBoard.AddComponent(cpu);
      motherBoard.AddComponent(ram);

      cabinate.AddComponent(motherBoard);
      cabinate.AddComponent(hardDisk);

      peripherals.AddComponent(mouse);
      peripherals.AddComponent(keyboard);

      computer.AddComponent(cabinate);
      computer.AddComponent(peripherals);

      Console.WriteLine("\nPrice of Computer composite components:");
      computer.DisplayPrice();

      Console.WriteLine("\nPrice of Keyboard composite components:");
      keyboard.DisplayPrice();

      Console.WriteLine("\nPrice of Cabinet composite components:");
      cabinate.DisplayPrice();

    }
  }
}
