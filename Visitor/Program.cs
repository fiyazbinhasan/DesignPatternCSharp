using System;
using System.Collections.Generic;
using System.Net.Mail;
using Visitor.CreditCards;
using Visitor.Offers;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard goldCard = new GoldCreditCard();
            ICreditCard platinumCard = new PlatinumCreditCard();

            IOfferVisitor primeDay = new PrimeDay();
            IOfferVisitor blackFriday = new BlackFriday();
            
            goldCard.Accept(primeDay);
            platinumCard.Accept(blackFriday);

            Console.ReadLine();
        }
    }
}
