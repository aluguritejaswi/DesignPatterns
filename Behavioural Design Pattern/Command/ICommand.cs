using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
  public interface ICommand
  {
    string Name { get; }
    void Execute();
  }

  public class StartCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("Executing StartCommand");
    }

    public string Name
    {
      get { return "Start"; }
    }
  }

  public class StopCommand : ICommand
  {
    public void Execute()
    {
      Console.WriteLine("Executing StopCommand");
    }

    public string Name
    {
      get { return "Stop"; }
    }
  }
}
