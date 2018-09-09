using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Plugin
    {
        protected readonly string _name;
        protected readonly decimal _price;
        public Plugin(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public virtual string Name
        {
            get { return _name; }
        }
        public virtual decimal Price
        {
            get { return _price; }
        }
    }
}
