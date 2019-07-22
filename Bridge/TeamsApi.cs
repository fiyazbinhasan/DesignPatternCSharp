using System;
using System.Collections.Generic;

namespace Bridge
{
    public class TeamsApi : IPlatformApi
    {
        public int MaxVisibleMessages { get; set; }

        public IEnumerable<string> LoadMessages()
        {
            return new[] {
                "Hi!",
                "Welcome to Microsoft Teams",
                "This should be easy.",
                "Have a quick tour",
                "We put a lot of stuff you might be interested in"
            };
        }
    }
}
