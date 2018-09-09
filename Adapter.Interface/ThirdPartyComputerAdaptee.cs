using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    public class ThirdPartyComputerAdaptee
    {
        public bool IsOn { get; private set; }
        public void TurnOn()
        {
            IsOn = true;
        }
    }
}
