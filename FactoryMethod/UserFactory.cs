using System;
namespace FactoryMethod
{
    public enum UserType
    {
        Customer,
        Supplier
    }
    public class UserFactory : IUserFactory
    {
        public IApplicationUser CreateUser(UserType user) => user switch
        {
            UserType.Supplier => new Supplier(),
            UserType.Customer => new Customer(),
            _ => throw new ArgumentException("Not a known user")
        };
    }
}
