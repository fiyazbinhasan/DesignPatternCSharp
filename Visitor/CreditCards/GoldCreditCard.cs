using Visitor.Offers;

namespace Visitor.CreditCards
{
    public class GoldCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitGoldCreditCard(this);
        }
    }
}