using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    internal interface IAggregate<T>
    {
        T this[int index] { get; set; }
        int Count { get; }

        IIterator<T> Iterator { get; }
    }

    internal class Aggregate<T> : IAggregate<T>
    {
        private IIterator<T> _iterator;
        private List<T> _list = new List<T>();
        public int Count => _list.Count;

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list.Add(value); }
        }

        public IIterator<T> Iterator
        {
            get
            {
                if (this._iterator == null) _iterator = new Iterator<T>(this);
                return _iterator;
            }
        }
    }

    internal class Person
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Person(string iName, int iAge)
        {
            this.Name = iName;
            this.Age = iAge;
        }
    }
}
