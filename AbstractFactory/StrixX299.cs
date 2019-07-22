using System;
namespace AbstractFactory
{
    public class StrixX299 : MotherBoard
    {
        public override string[] Combine(CPU cpu)
        {
            return new[] { cpu.GetType().Name, GetType().Name };
        }
    }
}
