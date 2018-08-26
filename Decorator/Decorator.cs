using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : SandwichComponent
    {
        protected SandwichComponent _component;
        protected string _name = "";
        protected decimal _price = 0;
        protected Decorator(SandwichComponent component)
        {
            _component = component;
        }

        public override string Name => $"{_component.Name} {_name}";

        public override decimal Price => _component.Price + _price;

        public class BaseSandwich
        {
            public BaseSandwich()
            {
            }
        }
    }
}
