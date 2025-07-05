using System;

namespace Observer
{
    internal class School : IObserver
    {
        private string _name;
        public School(string schoolName)
        {
            _name = schoolName;
        }

        public void Update(string news)
        {
            Console.WriteLine($"School {_name} received news: " + news);
        }
    }
}