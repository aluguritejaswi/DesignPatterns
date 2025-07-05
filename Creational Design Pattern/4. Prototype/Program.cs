using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(); enemy.Id = 1;
            Console.WriteLine("Enemy Copy ID: " + enemy.Id.ToString());

            Enemy clonedEnemy = enemy.Clone() as Enemy;
            Console.WriteLine("Enemy Copy ID: " + clonedEnemy.Id.ToString());

            Console.WriteLine($"Original Address: {enemy}");
            Console.WriteLine($"Shallow Clone Address: {clonedEnemy}");          
        }

        private static IntPtr GetObjectAddress(object obj)
        {
            GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
            IntPtr address = handle.AddrOfPinnedObject();
            handle.Free(); // Free the handle to avoid memory leaks
            return address;
        }
    }
}
