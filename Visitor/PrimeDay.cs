namespace Visitor
{
    public class PrimeDay : ISaleScheduler
    {
        public decimal SheduleSale(Game game)
        {
            return game.Price - (game.Price * .20M);
        }

        public decimal SheduleSale(Book book)
        {
            return book.Price - (book.Price * .45M);
        }
    }
}
