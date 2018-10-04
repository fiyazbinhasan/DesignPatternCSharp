namespace Visitor
{
    public class Game : ISale
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public decimal Participate(ISaleScheduler saleScheduler)
        {
            return saleScheduler.SheduleSale(this);
        }
    }
}
