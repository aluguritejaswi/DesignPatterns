using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
  static class Program
  {
    static void Main()
    {
      Invoker objInvoker = new Invoker();
      ICommand command = objInvoker.GetCommand("Start");
      command.Execute();

      command = objInvoker.GetCommand("Stop");
      command.Execute();
    }
  }
}
