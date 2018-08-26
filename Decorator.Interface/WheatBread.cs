using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interface
{
    public class WheatBread : Decorator
    {
        public WheatBread(ISandwichComponent component) : base(component)
        {
            _name = "Wheat Bread";
            _price = 2.00M;
        }
    }
}
