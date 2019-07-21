using System;
using Visitor.CreditCards;

namespace Visitor.Offers
{
    public class BlackFriday : IOfferVisitor
    {
        public void VisitPlatinumCreditCard(PlatinumCreditCard platinumCreditCard)
        {
            Console.WriteLine("It's Black Friday! 50% off on everything purchased with Platinum Card!");
        }

        public void VisitGoldCreditCard(GoldCreditCard goldCreditCard)
        {
            Console.WriteLine("It's Black Friday! 30% off on everything purchased with Platinum Card!");
        }

        public void VisitSilverCreditCard(SilverCreditCard silverCreditCard)
        {
            Console.WriteLine("It's Black Friday! 20% off on everything purchased with Platinum Card!");
        }
    }
}