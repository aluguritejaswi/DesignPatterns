using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPattern.SingleTon;

namespace DesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      SingleTon logWriter = SingleTon.GetInstance();
      logWriter.PrintDetails("Welcome");

      DerivedSingleton ds = new SingleTon.DerivedSingleton();
      ds.PrintDetails("Srinsoft");
    }
  }
}
