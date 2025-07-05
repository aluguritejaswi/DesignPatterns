using System;
using System.Collections.Generic;

namespace Memento
{
    internal class PlayerWindow
    {
        private List<State> listOfStates = new List<State>();

        int Current
        {
            get { return listOfStates.Count; }
            set { Current = listOfStates.Count; }
        }

        int Pivot = 0;
        internal void AddNewCommand()
        {
            int value = new Random().Next(1, 10), position = listOfStates.Count;
            State state = new State();
            state.SetValue(value);
            state.SetPosition(position);
            listOfStates.Add(state);
            Console.WriteLine("ADD VALUE: " + state.GetValue() + " at Position: " + state.GetPosition());
        }

        internal void Undo()
        {
            if(Current - 1 > 0)
            {
                State state = listOfStates[Current - 2];
                Console.WriteLine("UNDO: " + state.GetValue() + " at Position: " + state.GetPosition());
                listOfStates.RemoveAt(Current - 2);
            }
        }

        //internal void Redo()
        //{
        //    if(Current < listOfStates.Count - 1)
        //    {
        //        State state = listOfStates[Current + 1];
        //        Console.WriteLine("UNDO: " + state.GetValue() + " at Position: " + state.GetPosition());
        //        //Current--;
        //        listOfStates.RemoveAt(Current - 2);
        //    }
        //}
    }
}