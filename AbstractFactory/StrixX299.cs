using System;
namespace AbstractFactory
{
    public class StrixX299 : Mainboard
    {
        public override string[] Combine(CPU cpu)
        {
            return new string[] { cpu.GetType().Name, this.GetType().Name };
        }
    }
}
