using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("USER 1");
            User user2 = new User("USER 1");

            School school1 = new School("School 1");
            School school2 = new School("School 2");

            NewsAgency agency = new NewsAgency();

            agency.RegisterObserver(user1);
            agency.RegisterObserver(school1);
            agency.NotifyObservers("NEWS 1");

            Console.WriteLine();

            agency.RegisterObserver(user1);
            agency.RegisterObserver(school1);
            agency.NotifyObservers("NEWS 2");

            Console.WriteLine();

            agency.RegisterObserver(user1);
            agency.RegisterObserver(school1);
            agency.NotifyObservers("NEWS 3");
        }
    }
}
