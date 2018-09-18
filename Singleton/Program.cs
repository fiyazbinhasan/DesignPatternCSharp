using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration instanceOne =  Configuration.Instance;
            Configuration instanceTwo = Configuration.Instance;

            Console.WriteLine(instanceOne == instanceTwo);
        }
    }
}
