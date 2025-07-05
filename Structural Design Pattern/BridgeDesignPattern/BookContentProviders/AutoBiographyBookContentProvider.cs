using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BookContentProviders
{
  public class AutoBiographyBookContentProvider : IBookContentProvider
  {
    public IEnumerable<string> GetContent()
    {
      return new List<string>
      {
        "I was born.",
        "I learned to program.",
        "I became a YouTuber."
      };
    }
  }
}
