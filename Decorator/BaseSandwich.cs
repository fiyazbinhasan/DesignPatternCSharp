using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class BaseSandwich : SandwichComponent
    {
        private string _name = "Basic Sandwich";
        private decimal _price = 1.0M;
        public override string Name => _name;

        public override decimal Price => _price;
    }
}
