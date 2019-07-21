using System;
using Visitor.CreditCards;

namespace Visitor.Offers
{
    public class PrimeDay : IOfferVisitor
    {
        public void VisitPlatinumCreditCard(PlatinumCreditCard platinumCreditCard)
        {
            Console.WriteLine("It's PrimeDay! 20% off on everything purchased with Platinum Card!");
        }

        public void VisitGoldCreditCard(GoldCreditCard goldCreditCard)
        {
            Console.WriteLine("It's PrimeDay! 10% off on everything purchased with Gold Card!");
        }

        public void VisitSilverCreditCard(SilverCreditCard silverCreditCard)
        {
            Console.WriteLine("It's PrimeDay! 5% off on everything purchased with Silver Card!");
        }
    }
}