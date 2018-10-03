using System;
namespace Iterator
{
    public interface IIterable
    {
        IIterator GetIterator();
    }
}
