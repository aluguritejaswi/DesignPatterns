using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerWindow window = new PlayerWindow();
            window.AddNewCommand();
            window.AddNewCommand();
            window.AddNewCommand();
            window.AddNewCommand();
            window.AddNewCommand();
            window.AddNewCommand();

            window.Undo();
            window.Undo();
            //window.Redo();
            window.Undo();

            //window.Redo(); 
            //window.Redo();

        }
    }
}
