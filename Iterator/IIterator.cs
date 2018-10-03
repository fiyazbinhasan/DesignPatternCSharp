using System;
namespace Iterator
{
    public interface IIterator
    {
        bool MoveNext();
        Object Current { get; }
        void Reset();
    }
}
