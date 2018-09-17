using System;
namespace FactoryMethod
{
    public class Supplier : IApplicationUser
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string SupplyGoods()
        {
            return "Goods supplied!";
        }
    }
}
