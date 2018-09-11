using System;

public class CustomerRepository : ICustomerRepository
{
    public Customer GetById(int id)
    {
        Console.WriteLine("Called");

        return new Customer
        {
            Name = "Something",
            Address = "123 Street"
        };
    }
}

public interface ICustomerRepository {
    Customer GetById(int id);
}
