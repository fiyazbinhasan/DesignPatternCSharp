using Visitor.Offers;

namespace Visitor.CreditCards
{
    public class SilverCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitSilverCreditCard(this);
        }
    }
}