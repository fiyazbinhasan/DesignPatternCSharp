using System;
namespace FactoryMethod
{
    public class Customer : IApplicationUser
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string BuyGoods()
        {
            return "Goods bought";
        }
    }
}
