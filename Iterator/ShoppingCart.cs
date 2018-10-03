using System;
namespace Iterator
{
    public class ShoppingCart : IIterable
    {
        CartItem[] _items;

        public ShoppingCart(CartItem[] items)
        {
            _items = items;
        }

        public IIterator GetIterator()
        {
            return new ShoppingCartIterator(_items);
        }

        public decimal Total()
        {
            decimal total = 0;
            var iterator = GetIterator();

            while (iterator.MoveNext())
            {
                var currentItem = (CartItem)iterator.Current;
                total += currentItem.Product.UnitPrice * currentItem.Quantity;
            }

            return total;
        }
    }
}
