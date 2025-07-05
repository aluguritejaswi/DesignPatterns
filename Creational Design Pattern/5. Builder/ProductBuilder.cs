using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ProductBuilder : IProductBuilder
    {
        private readonly Product _product = new Product();

        public IProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }
        public IProductBuilder SetColor(string color)
        {
            _product.Color = color;
            return this;
        }

        public Product Build() => _product;
    }
}
