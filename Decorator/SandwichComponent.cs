using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class SandwichComponent
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
    }
}
