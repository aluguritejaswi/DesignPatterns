using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public interface IQuackBehaviour
    {
        void Quack();
    }

    public class Quacking : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack..!");
        }
    }

    public class Muted : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I have muted");
        }
    }
}
