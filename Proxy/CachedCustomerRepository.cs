using Microsoft.Extensions.Caching.Memory;

public class CachedCustomerRepository
{
    readonly MemoryCache cache = new MemoryCache(new MemoryCacheOptions());
    ICustomerRepository _customerRepository;

    public CachedCustomerRepository(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Customer GetById(int id)
    {
        var key = "customer-entity-" + id;
        var entity = cache.Get(key) as Customer;

        if (entity == null)
        {
            entity = _customerRepository.GetById(id);
            cache.Set(key, entity);
        }
        return entity;
    }
}