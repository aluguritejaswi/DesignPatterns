using System;
using System.Collections.Generic;

namespace Observer
{
    internal class NewsAgency : ISubject
    {
        public NewsAgency()
        {

        }
        private List<IObserver> _observers = new List<IObserver>();

        public void NotifyObservers(string news)
        {
            foreach (var observer in _observers)
            {
                observer.Update(news);
            }
        }

        internal void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}