using System;
namespace FactoryMethod
{
    public class UserFactory : IUserFactory
    {
        public IApplicationUser CreateUser(string userType)
        {
            switch (userType.ToUpper())
            {
                case "SUPPLIER":
                    return new Supplier();
                case "CUSTOMER":
                    return new Customer();
                default:
                    return null;
            }
        }
    }
}
