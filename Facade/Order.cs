using System.Collections.Generic;

namespace Facade
{
    public class Order
    {
        public Order()
        {
            Items = new List<Item>();
        }

        public string OrderNo { get; set; }
        public List<Item> Items { get; set; }
    }
}