namespace AbstractFactory
{
    public class IntelFactory : VendorFactory
    {
        public override CPU CreateCPU()
        {
            return new SkylakeI9();
        }

        public override Mainboard GetMainboard()
        {
            return new StrixX299();
        }
    }
}