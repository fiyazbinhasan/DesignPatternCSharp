using System;
namespace FactoryMethod
{
    public interface IUserFactory
    {
        IApplicationUser CreateUser(string userType);
    }
}
