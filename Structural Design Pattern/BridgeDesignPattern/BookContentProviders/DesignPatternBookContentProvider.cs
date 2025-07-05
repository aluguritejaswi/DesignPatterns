using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BookContentProviders
{
  public class DesignPatternBookContentProvider : IBookContentProvider
  {
    public IEnumerable<string> GetContent()
    {
      return new List<string>
      {
        "The Bridge Pattern is awesome"
      };
    }
  }
}
