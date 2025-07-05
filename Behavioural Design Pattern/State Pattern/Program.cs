using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BrushTool brushTool = new BrushTool();
            Canvas canvas = new Canvas();
            canvas.CurTool = brushTool;
            canvas.MouseUp();
        }
    }
}
