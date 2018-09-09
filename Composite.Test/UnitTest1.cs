using System;
using Xunit;

namespace Composite.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Computer myPc = new Computer();

            Motherboard motherboard = new Motherboard("GIGABYTE Z270X", 100M);
            Motherboard motherboard2 = new Motherboard("GIGABYTE Z370X", 100M);
            CPU cpu2 = new CPU("INTEL I7", 130M);
            CPU cpu = new CPU("INTEL I7", 150M);
            Cooler cooler = new Cooler("Stock Cooler", 50);

            cpu.AddPlugin(cooler);
            motherboard.AddPlugin(cpu);
            motherboard.AddPlugin(cpu2);
            myPc.AddPlugin(motherboard);
            myPc.AddPlugin(motherboard2);

            Assert.Equal(530, myPc.GetTotal());
        }
    }
}
