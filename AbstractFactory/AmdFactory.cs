using System;
namespace AbstractFactory
{
    public class AmdFactory : VendorFactory
    {
        public override CPU CreateCPU()
        {
            return new Ryzen5();
        }

        public override Mainboard GetMainboard()
        {
            return new StrixB450();
        }
    }
}
