using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BridgeDesignPattern.BookContentProviders;
using BridgeDesignPattern.BookPublishers;
using BridgeDesignPattern.Books;

namespace BridgeDesignPattern
{
  class Program
  {
    static void Main(string[] args)
    {
      IBookContentProvider contentProvider = new AutoBiographyBookContentProvider();
      IBookPublisher publisher = new DigitalBookPublisher();
      Book objBook = new Book(contentProvider, publisher);
      objBook.Publish();
    }
  }
}
