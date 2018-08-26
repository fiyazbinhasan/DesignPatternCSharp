using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Bacon : Decorator
    {
        public Bacon(SandwichComponent component) : base(component)
        {
            _name = "Bacon";
            _price = 3.00M;
        }
    }
}
