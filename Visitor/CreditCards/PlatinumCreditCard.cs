using Visitor.Offers;

namespace Visitor.CreditCards
{
    public class PlatinumCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitPlatinumCreditCard(this);
        }
    }
}