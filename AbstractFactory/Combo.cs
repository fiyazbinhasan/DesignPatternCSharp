using System;

namespace AbstractFactory
{
    public class Combo
    {
        private Mainboard _mainboard;
        private CPU _cpu;

        public Combo(VendorFactory vendor)
        {
            _cpu = vendor.CreateCPU();
            _mainboard = vendor.GetMainboard();
        }

        public string[] CreateCombo()
        {
            return _mainboard.Combine(_cpu);
        }
    }
}