using System;
namespace Iterator
{
    public class ShoppingCartIterator : IIterator
    {
        public CartItem[] _items;

        int position = -1;

        public ShoppingCartIterator(CartItem[] items)
        {
            _items = items;
        }

        public object Current => _items[position];

        public bool MoveNext()
        {
            position++;
            return (position < _items.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
