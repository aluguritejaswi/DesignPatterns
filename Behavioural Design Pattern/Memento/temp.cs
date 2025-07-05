using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditorMemento
    {
        public string Text { get; }

        public TextEditorMemento(string text)
        {
            Text = text;
        }
    }

    public class TextEditor
    {
        private string _text;

        public void Type(string words)
        {
            _text += words;
        }

        public void ShowText()
        {
            Console.WriteLine(_text);
        }

        public TextEditorMemento Save()
        {
            return new TextEditorMemento(_text);
        }

        public void Restore(TextEditorMemento memento)
        {
            _text = memento.Text;
        }
    }

    public class History
    {
        private Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

        public void Save(TextEditor editor)
        {
            _history.Push(editor.Save());
        }

        public void Undo(TextEditor editor)
        {
            if (_history.Count > 0) editor.Restore(_history.Pop());
        }
    }

    class Program1
    {
        static void Memento()
        {
            TextEditor editor = new TextEditor();
            History history = new History();

            editor.Type("Hello");
            history.Save(editor);

            editor.Type(" World");
            history.Save(editor);

            editor.Type("!!!");
            history.Save(editor);

            history.Undo(editor);
            editor.ShowText();

            history.Undo(editor);
            editor.ShowText();
        }
    }
}
