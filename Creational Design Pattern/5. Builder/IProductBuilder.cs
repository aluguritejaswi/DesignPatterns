using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IProductBuilder
    {
        IProductBuilder SetName(string name);
        IProductBuilder SetColor(string color);

        Product Build();

    }
}
