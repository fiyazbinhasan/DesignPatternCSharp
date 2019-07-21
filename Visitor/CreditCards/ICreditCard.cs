using Visitor.Offers;

namespace Visitor.CreditCards
{
    public interface ICreditCard
    {
        void Accept(IOfferVisitor visitor);
    }
}