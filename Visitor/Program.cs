using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PrimeDay primeDay = new PrimeDay();

            Game dmc = new Game { Title = "Devil May Cry", Price = 39.99M };
            Book gof = new Book { Title = "Gang of Four", Price = 45.99M };

            Console.WriteLine($"{dmc.Title}\tRegular Price: {dmc.Price:#.##}\tPrime Day Offer: {dmc.Participate(primeDay):#.##}");

            Console.WriteLine($"{gof.Title}\tRegular Price: {gof.Price:#.##}\tPrime Day Offer: {gof.Participate(primeDay):#.##}");

            Console.ReadLine();
        }
    }
}
