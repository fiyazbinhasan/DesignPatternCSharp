using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public interface IPluggable<T> 
    {
        IList<T> Plugins { get; }
        void AddPlugin(T plugin);
    }
}
