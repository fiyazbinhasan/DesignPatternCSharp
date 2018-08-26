using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Ham : Decorator
    {
        public Ham(SandwichComponent component) : base(component)
        {
            _name = "Ham";
            _price = 2.00M;
        }
    }
}
