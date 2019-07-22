using System.Collections.Generic;

namespace Bridge
{
    public class DiscordApi : IPlatformApi
    {
        public int MaxVisibleMessages { get; set; }

        public IEnumerable<string> LoadMessages()
        {
            return new[]
            {
                "Welcome to Discord!",
                "Gaming chat simplified.",
                "In game window for communicating with your team mates.",
                "Steam integration"
            };
        }
    }
}