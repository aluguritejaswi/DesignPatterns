using System;

namespace Observer
{
    internal class User : IObserver
    {
        private string _name { get; }
        public User(string userName) 
        {
            _name = userName;
        }

        public void Update(string news)
        {
            Console.WriteLine($"User {_name} received news: " + news);
        }
    }
}