using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.BookPublishers
{
  public class AudioBookPublisher : IBookPublisher
  {
    public void Publish(IEnumerable<string> bookContent)
    {
      Console.WriteLine($"Successfully uploaded in audio book. ({bookContent.Count()} lines)");
    }
  }
}
