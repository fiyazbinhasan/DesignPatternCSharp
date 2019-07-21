using System;
namespace Iterator
{
    public class ShoppingCartIterator : IIterator
    {
        private readonly CartItem[] _items;

        int _position = -1;

        public ShoppingCartIterator(CartItem[] items)
        {
            _items = items;
        }

        public object Current => _items[_position];

        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Length);
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
