using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserFactory factory = new UserFactory();

            var userOne = factory.CreateUser(UserType.Supplier);
            Console.WriteLine(userOne);


            var userTwo = factory.CreateUser(UserType.Customer);
            Console.WriteLine(userTwo.GetType());

            Console.ReadLine();
        }
    }
}
