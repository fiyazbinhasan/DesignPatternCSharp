using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myPc = new Computer();

            Motherboard motherboard = new Motherboard("GIGABYTE Z270X", 200M);
            CPU cpu = new CPU("INTEL I7", 150M);
            Cooler cooler = new Cooler("Stock Cooler", 50);
            
            cpu.AddPlugin(cooler);
            motherboard.AddPlugin(cpu);
            myPc.AddPlugin(motherboard);

            Console.WriteLine(myPc.GetTotal());
            Console.ReadLine();

        }
    }
}
