namespace Iterator
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Product.UnitPrice * Quantity;
    }
}