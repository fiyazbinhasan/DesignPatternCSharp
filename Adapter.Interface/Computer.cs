using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    public class Computer : IComputer
    {
        public bool IsOn { get; private set; }
        public void PowerOn()
        {
            IsOn = true;
        }
    }
}
