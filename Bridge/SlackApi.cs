using System;
using System.Collections.Generic;

namespace Bridge
{
    public class SlackApi : IPlatformApi
    {

        public IEnumerable<string> LoadMessages()
        {
            return new[] { 
                "Hi!",
                "Welcome to Slack!",
                "This should be easy.",
                "Have a quick tour"
            };
        }
    }
}
