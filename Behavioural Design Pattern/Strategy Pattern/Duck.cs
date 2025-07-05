using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public abstract class Duck
    {
        internal IQuackBehaviour quackBehaviour;
        internal IFlyBehaviour flyBehaviour;
        public abstract void Display();

        public void Fly()
        {
            // Console.WriteLine("Fly"); //old
            flyBehaviour.Fly();
        }
        public void Quack()
        {
            // Console.WriteLine("Quack");  //old 
            quackBehaviour.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("Swim");
        }
        public void Walk()
        {
            Console.WriteLine("Walk");
        }

        public void SetFlyBehaviour(IFlyBehaviour fly)
        {
            flyBehaviour = fly;
        }        
        
        public void SetQuackBehaviour(IQuackBehaviour quack)
        {
            quackBehaviour = quack;
        }

    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quacking();
        }
        public override void Display()
        {
            Console.WriteLine("I'm Mallard Duck");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new Muted();
        }
        public override void Display()
        {
            Console.WriteLine("I'm Rubber Duck");
        }
    }
}
