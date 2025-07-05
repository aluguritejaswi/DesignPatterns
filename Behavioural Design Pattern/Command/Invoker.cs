using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
  public class Invoker
  {
    ICommand cmd = null;
    public Invoker()
    {
    }
 
    public ICommand GetCommand(string action)
    {
      switch (action)
      {
        case "Start":
          cmd = new StartCommand();
          break;

        case "Stop":
          cmd = new StopCommand();
          break;
        default:
          break;
      }
      return cmd;
    }
  }
}
