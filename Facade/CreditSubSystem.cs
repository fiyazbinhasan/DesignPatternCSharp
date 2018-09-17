using System;
namespace Facade
{
    public class CreditSubSystem
    {
        public const int MAX_TRANSACTION_LIMIT_PER_DAY = 3;

        public bool IsCreditSufficient(CreditCard card, decimal amount){
            return card.AvailableCredit >= amount;
        }

        public bool CrossedTransactionLimit(CreditCard card){
            return card.TotalTransactionOfTheDay >= MAX_TRANSACTION_LIMIT_PER_DAY;
        }
    }
}
