using System;
using System.Collections.Generic;

namespace Bridge
{
    public class TeamsAPI : IPlatformAPI
    {
        public IEnumerable<string> LoadMessages()
        {
            return new List<string>() {
                "Hi!",
                "Welcome to Microsoft Teams",
                "This should be easy.",
                "Have a quick tour",
                "We put a lot of stuff you might be interested in"
            };
        }
    }
}
