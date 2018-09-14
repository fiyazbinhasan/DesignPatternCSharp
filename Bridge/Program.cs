using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var slackSubscription = new FreeSubscription(new SlackAPI()) { MaxLimitOnMessages = 2 };
            foreach (var message in slackSubscription.GetMessages())
            {
                Console.WriteLine(message);
            }

            var msftSubscription = new PremiumSubscription(new TeamsAPI());
            foreach (var message in msftSubscription.GetMessages())
            {
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
