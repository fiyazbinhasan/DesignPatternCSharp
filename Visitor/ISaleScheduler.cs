namespace Visitor
{
    public interface ISaleScheduler
    {
        decimal SheduleSale(Game game);
        decimal SheduleSale(Book book);
    }
}
