using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    public class ThirdPartyComputerAdpter : IComputer
    {
        private readonly ThirdPartyComputerAdaptee _computer;
        public ThirdPartyComputerAdpter(ThirdPartyComputerAdaptee computer)
        {
            this._computer = computer;
        }

        public bool IsOn => _computer.IsOn;

        public void PowerOn()
        {
            _computer.TurnOn();
        }
    }
}
