using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public abstract class DialogBox
        {
            public abstract void Change(UIControl control);
        }

        class ArticlesDialogBox : DialogBox
        {
            private ListBox listBox;
            private TextBox textBox;
            private Button saveButton;

            public ArticlesDialogBox()
            {

            }

            public override void Change(UIControl control)
            {
                if(control is ListBox)
                {
                }
                else if (control is TextBox)
                {
                }
                else if (control is Button)
                {
                }
            }
        }

        internal class Button
        {
        }

        internal class TextBox
        {
        }

        internal class ListBox
        {
        }

        public class UIControl
        {
            protected DialogBox owner;
            public UIControl(DialogBox iOwner) => this.owner = iOwner;
        }
    }
}
