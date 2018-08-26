using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interface
{
    public abstract class Decorator : ISandwichComponent
    {
        protected ISandwichComponent _component;
        protected string _name;
        protected decimal _price;

        public Decorator(ISandwichComponent component)
        {
            _component = component;
        }
        public string Name => $"{_component.Name} {_name}";

        public decimal Price => _component.Price + _price;
    }
}
