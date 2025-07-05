using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class AbstractEnemy
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public abstract AbstractEnemy Clone();
    }

    public class Enemy : AbstractEnemy
    {
        public override AbstractEnemy Clone()
        {
            Console.WriteLine("cloning enemy...");
            return this.MemberwiseClone() as AbstractEnemy;
        }
    }

}
