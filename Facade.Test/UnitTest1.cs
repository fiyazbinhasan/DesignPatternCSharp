using System;
using System.Collections.Generic;
using Xunit;

namespace Facade.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cart = new List<Item> { new Item { Title = "Headphone", Price = 25 } };
            var creditCard = new CreditCard { TotalTransactionOfTheDay = 2, AvailableCredit = 20, CardNo = "2134 2341 5634 6556" };

            OrderFacade facade = new OrderFacade();

            Action act = () => facade.PlaceOrder(cart, creditCard);

            Assert.Throws<Exception>(act);
        }
    }
}
