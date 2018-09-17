using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new List<Item> { new Item { Title = "Headphone", Price = 20 } };
            var creditCard = new CreditCard { TotalTransactionOfTheDay = 2, AvailableCredit = 20, CardNo = "2134 2341 5634 6556" };

            OrderFacade facade = new OrderFacade();

            try
            {
                Console.WriteLine(facade.PlaceOrder(cart, creditCard));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
