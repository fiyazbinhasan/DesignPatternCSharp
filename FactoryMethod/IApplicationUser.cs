using System;
namespace FactoryMethod
{
    public interface IApplicationUser
    {
        int Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
