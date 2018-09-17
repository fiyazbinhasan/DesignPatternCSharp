namespace AbstractFactory
{
    public abstract class VendorFactory
    {
        public abstract CPU CreateCPU();
        public abstract Mainboard GetMainboard();
    }
}