namespace AbstractFactory
{
    public class IntelFactory : VendorFactory
    {
        public override CPU GetCpu()
        {
            return new SkylakeI9();
        }

        public override MotherBoard GetMotherboard()
        {
            return new StrixX299();
        }
    }
}