using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.FirstName = "Bla";
            cust.LastName = "Gla";
            cust.Address = new Address()
            {
                PrimaryAddress = "123",
                SecondaryAddress = "232"
            };

            var address = (Address) cust.Address.Clone();
            address.PrimaryAddress = "rent";

            var customerClone = (Customer) cust.Clone();

            Console.WriteLine(cust.Address.PrimaryAddress = "srw");

            Console.WriteLine(address.PrimaryAddress);
            Console.WriteLine(customerClone.Address.PrimaryAddress);

            Console.ReadLine();
        }
    }
}
