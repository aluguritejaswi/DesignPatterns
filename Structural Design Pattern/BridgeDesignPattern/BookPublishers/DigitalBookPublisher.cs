using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BookPublishers
{
  public class DigitalBookPublisher : IBookPublisher
  {
    public void Publish(IEnumerable<string> bookContent)
    {
      Console.WriteLine($"Successfully added in digital book. ({bookContent.Count()} lines)");
    }
  }
}
