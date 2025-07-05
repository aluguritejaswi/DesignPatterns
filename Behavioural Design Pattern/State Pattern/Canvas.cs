using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    public class Canvas
    {
        private ITool objTool = default;
        internal ITool CurTool { get => objTool; set => objTool = value; }
        public void MouseDown()
        {
            Console.WriteLine("Canvas activated");
            CurTool.MouseDown();
        }

        public void MouseUp()
        {
            Console.WriteLine("Canvas activated");
            CurTool.MouseUp();
        }
    }
}
