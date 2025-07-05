using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chain_of_Responsibility
{
    //public record ExpenseReport(string Name, int Amount);
    public class ExpenseReport
    {
        public string name { get; private set; }
        public int amount { get; private set; }

        public ExpenseReport(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
    internal interface IManager
    {
        void SetSupervisor(IManager manager);
        void ApproveRequest(ExpenseReport expenseReport);
    }
    internal class SeniorManager : IManager
    {
        IManager _manager;
        public void SetSupervisor(IManager manager)
        {
            _manager = manager;
        }
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.amount < 500)
                Console.WriteLine("Senior Manager Approved..!");
            else
                _manager?.ApproveRequest(expenseReport);
        }
    }
    internal class VicePresident : IManager
    {
        IManager _manager;
        public void SetSupervisor(IManager manager)
        {
            _manager = manager;
        }
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.amount < 1000)
                Console.WriteLine("VicePresident Approved..!");
            else
                _manager?.ApproveRequest(expenseReport);
        }
    }

    internal class CEO : IManager
    {
        IManager _manager;
        public void SetSupervisor(IManager manager)
        {
            _manager = manager;
        }
        public void ApproveRequest(ExpenseReport expenseReport)
        {
            if (expenseReport.amount < 2000)
                Console.WriteLine("CEO Approved..!");  
            else
                Console.WriteLine("*X* Not Approved..!");

        }
    }
}


