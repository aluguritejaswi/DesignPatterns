using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IFood
    {
       void Prepare();
    }
    class Pizza : IFood
    {
        public void Prepare()
        {
            Console.WriteLine("\nPizza Base Prepared");
        }
    }

    public class PizzaDecorator : IFood
    {
        IFood _pizza;
        public PizzaDecorator(IFood pizza)
        {
            _pizza = pizza;
        }
        public virtual void Prepare()
        {
            _pizza.Prepare();
        }
    }

    //we can create different sub classes of pizza decorators
    public class PerperiPizza : PizzaDecorator
    {
        IFood _pizza;
        public PerperiPizza(IFood pizza) : base(pizza)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("PerperiPizza");
        }
    }
    public class OnionPizza : PizzaDecorator
    {
        IFood _pizza;
        public OnionPizza(IFood pizza) : base(pizza)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("OnionPizza");
        }
    }
    public class TomatoPizza : PizzaDecorator
    {
        IFood _pizza;
        public TomatoPizza(IFood pizza) : base(pizza)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("TomatoPizza");
        }
    }
    public class CapsicumPizza : PizzaDecorator
    {
        IFood _pizza;
        public CapsicumPizza(IFood pizza) : base(pizza)
        {
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("CapsicumPizza");
        }
    }
}
