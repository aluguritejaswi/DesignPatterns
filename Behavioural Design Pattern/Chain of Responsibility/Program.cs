using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new SeniorManager();
            var vp = new VicePresident();
            var coo = new CEO();

            //chain of responsibility is given here
            manager.SetSupervisor(vp);
            vp.SetSupervisor(coo);

            var expense = new ExpenseReport("CPU", 200);
            Console.WriteLine(expense);
            manager.ApproveRequest(expense);
            Console.WriteLine("-----------------------");

            expense = new ExpenseReport("Desk", 800);
            Console.WriteLine(expense);
            manager.ApproveRequest(expense);
            Console.WriteLine("-----------------------");

            expense = new ExpenseReport("Lapi", 2800);
            Console.WriteLine(expense);
            manager.ApproveRequest(expense);
            Console.WriteLine("-----------------------");
        }
    }
}
