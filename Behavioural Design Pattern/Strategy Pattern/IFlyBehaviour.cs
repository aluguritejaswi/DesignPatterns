using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public interface IFlyBehaviour
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings");
        }
    }

    public class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't Fly");
        }
    }
}
