using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Swim();
            mallardDuck.Fly();
            mallardDuck.Quack();
            mallardDuck.Walk();

            Console.WriteLine();

            RubberDuck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Swim();
            rubberDuck.Fly();
            rubberDuck.Quack();
            rubberDuck.Walk();

            Console.WriteLine("I have changed quack behaviour for rubber duck");
            rubberDuck.SetQuackBehaviour(new Quacking());
            rubberDuck.Quack();
        }
    }
}
