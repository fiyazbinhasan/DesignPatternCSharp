using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class Combo
    {
        private readonly MotherBoard _motherBoard;
        private readonly CPU _cpu;

        public Combo(VendorFactory vendor)
        {
            _cpu = vendor.GetCpu();
            _motherBoard = vendor.GetMotherboard();
        }

        public IEnumerable<string> CreateCombo()
        {
            return _motherBoard.Combine(_cpu);
        }
    }
}