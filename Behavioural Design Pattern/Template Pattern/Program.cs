using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HiringProcess hiring = new CSEDepartment();

            Console.WriteLine("******HIRING FOR CSE DEPARTMENT");
            hiring.HireFreshers();

            Console.WriteLine();
            hiring = new ECEDepartment();
            Console.WriteLine("******HIRING FOR ECE DEPARTMENT");
            hiring.HireFreshers();
        }
    }
}
