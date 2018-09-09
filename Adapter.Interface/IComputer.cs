using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    public interface IComputer
    {
        bool IsOn { get; }
        void PowerOn();
    }
}
