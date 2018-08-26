using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interface
{
    public class BaseSandwich : ISandwichComponent
    {
        public string Name => "Base Sandwich";
        public decimal Price => 1.00M;
    }
}
