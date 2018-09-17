using System;
using System.Collections.Generic;

namespace Facade
{
    public class OrderSubSystem
    {
        public string CreateOrder(List<Item> items){
            Order order = new Order();
            order.Items.AddRange(items);
            order.OrderNo = "ORD-001";

            return $"Order created: {order.OrderNo}";
        }
    }
}
