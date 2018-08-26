using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Interface
{
    public interface ISandwichComponent
    {
        string Name { get; }
        decimal Price { get; }
    }
}
