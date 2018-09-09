using System;

namespace Adapter.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputer computer = new Computer();
            computer.PowerOn();

            Console.WriteLine($"Third party computer is powered on: {computer.IsOn}");

            ThirdPartyComputerAdaptee thirdPartyComputer = new ThirdPartyComputerAdaptee();

            IComputer adapter = new ThirdPartyComputerAdpter(thirdPartyComputer);
            adapter.PowerOn();

            Console.WriteLine($"Third party computer is turned on: {adapter.IsOn}");
            Console.ReadLine();
        }
    }
}
