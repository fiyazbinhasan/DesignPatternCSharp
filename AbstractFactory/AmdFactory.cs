using System;
namespace AbstractFactory
{
    public class AmdFactory : VendorFactory
    {
        public override CPU GetCpu()
        {
            return new Ryzen5();
        }

        public override MotherBoard GetMotherboard()
        {
            return new StrixB450();
        }
    }
}
