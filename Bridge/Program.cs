using System;
using System.Linq;

namespace Bridge
{
    static class Program
    {
        static void Main(string[] args)
        {
            var slack = new FreeSubscription(new SlackApi(), 2) ;
            var discord = new FreeSubscription(new DiscordApi(), 3);
            var teams = new PremiumSubscription(new TeamsApi());
            
            slack.GetMessages().ToList().ForEach(Console.WriteLine);
            discord.GetMessages().ToList().ForEach(Console.WriteLine);
            teams.GetMessages().ToList().ForEach(Console.WriteLine);
            
            Console.ReadLine();
        }
    }
}
