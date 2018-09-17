using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserFactory factory = new UserFactory();

            var userOne = factory.CreateUser("SUPPLIER");
            Console.WriteLine(userOne.GetType());


            var userTwo = factory.CreateUser("Customer");
            Console.WriteLine(userTwo.GetType());

            Console.ReadLine();
        }
    }
}
