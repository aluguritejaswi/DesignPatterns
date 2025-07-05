using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    // Subject interface
    public interface IImage
    {
        void Display();
    }

    // RealSubject class
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string filename)
        {
            _filename = filename;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Loading {_filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying {_filename}");
        }
    }

    // Proxy class
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
}
