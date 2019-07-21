using Visitor.CreditCards;

namespace Visitor.Offers
{
    public interface IOfferVisitor
    {
        void VisitPlatinumCreditCard(PlatinumCreditCard platinumCreditCard);
        void VisitGoldCreditCard(GoldCreditCard goldCreditCard);
        void VisitSilverCreditCard(SilverCreditCard silverCreditCard);
    }
}