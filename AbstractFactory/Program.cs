using System;
using System.Linq;

namespace AbstractFactory
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intel Combo:");
            Console.WriteLine("============");

            VendorFactory intel = new IntelFactory();
            Combo combo = new Combo(intel);
            combo.CreateCombo().ToList().ForEach(i => Console.WriteLine($"{i}"));

            Console.WriteLine();

            Console.WriteLine("AMD Combo:");
            Console.WriteLine("============");

            VendorFactory amd = new AmdFactory();
            combo = new Combo(amd);
            combo.CreateCombo().ToList().ForEach(i => Console.WriteLine($"{i}"));

            Console.ReadLine();
        }
    }
}
