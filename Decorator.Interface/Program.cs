using System;

namespace Decorator.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new BaseSandwich();

            Console.WriteLine($"{sandwich.Name}\t{sandwich.Price}");

            var wheatBreadSandwich = new WheatBread(new WheatBread(sandwich));

            Console.WriteLine($"{wheatBreadSandwich.Name}\t{wheatBreadSandwich.Price}");

            Console.ReadLine();
        }
    }
}
