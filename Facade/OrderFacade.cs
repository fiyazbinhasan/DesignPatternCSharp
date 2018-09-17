using System;
using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    public class OrderFacade
    {
        private readonly OrderSubSystem _orderSystem = new OrderSubSystem();
        private readonly CreditSubSystem _creditSystem = new CreditSubSystem();

        public string PlaceOrder(List<Item> cart, CreditCard card){
            if (_creditSystem.CrossedTransactionLimit(card))
                throw new Exception("Max transaction limit of the day crossed");
            if (!_creditSystem.IsCreditSufficient(card, cart.Sum(i => i.Price)))
                throw new Exception("Insufficient Crdit");
            return _orderSystem.CreateOrder(cart);
        }
    }
}
