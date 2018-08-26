using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class WheatBread : Decorator
    {
        public WheatBread(SandwichComponent component) : base(component)
        {
            _name = "Wheat Bread";
            _price = 1.00M;
        }
    }
}
