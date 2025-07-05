using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class State
    {
        private int _position;
        private int _value;

        public State()
        {

        }

        public int GetPosition() => _position;

        public bool SetPosition(int position)
        {
            _position = position;
            return true;
        }

        public int GetValue() => _value;

        public bool SetValue(int value)
        {
            _value = value;
            return true;
        }
    }
}
