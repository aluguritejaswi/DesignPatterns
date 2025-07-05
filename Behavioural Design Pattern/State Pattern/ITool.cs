using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public interface ITool
    {
        void MouseUp();
        void MouseDown();
    }

    public class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse Down in Selection tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse Down in Selection tool");
        }
    }    
    
    public class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse Down in Brush tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse Down in Brush tool");
        }
    }    
    
    public class EraseTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse Down in Erase tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse Down in Erase tool");
        }
    }
}
