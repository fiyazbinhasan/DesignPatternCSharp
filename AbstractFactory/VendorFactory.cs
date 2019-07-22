namespace AbstractFactory
{
    public abstract class VendorFactory
    {
        public abstract CPU GetCpu();
        public abstract MotherBoard GetMotherboard();
    }
}