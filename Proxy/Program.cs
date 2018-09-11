using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var customerRepo = new CustomerRepository();
            var cachedCustomerRepo = new CachedCustomerRepository(customerRepo);

            cachedCustomerRepo.GetById(1);
            cachedCustomerRepo.GetById(1);
            Console.ReadLine();
        }
    }
}
