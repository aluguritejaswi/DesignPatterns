using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
  // The base Component class declares the common operations for both simple and complex objects.
  public interface IComponent
  {
    void DisplayPrice();
  }

  // The Leaf class represents the end objects. 
  // A leaf can't have any children.
  // The Leaf object is the Object which does the actual work
  public class Leaf : IComponent
  {
    public int Price { get; set; }
    public string Name { get; set; }

    public Leaf(int iPrice, string iName)
    {
      this.Price = iPrice;
      this.Name = iName;
    }

    public void DisplayPrice()
    {
      Console.WriteLine($"Component Name: {Name} and Price: {Price}");
    }
  }

  // The Composite class represents the complex components that have children. 
  // The Composite objects delegate the actual work to their children and then combine the result.
  public class Composite : IComponent
  {
    public string Name { get; set; }

    List<IComponent> components = new List<IComponent>();

    public Composite(string iName)
    {
      this.Name = iName;
    }

    //The following Method is used to add Child Components inside the Composite Component
    public void AddComponent(IComponent component)
    {
      components.Add(component);
    }

    //Display the Price of Composite Components
    public void DisplayPrice()
    {
      foreach (var item in components)
      {
        item.DisplayPrice();
      }
    }
  }
}
