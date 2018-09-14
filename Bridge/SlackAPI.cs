using System;
using System.Collections.Generic;

namespace Bridge
{
    public class SlackAPI : IPlatformAPI
    {
        public IEnumerable<string> LoadMessages()
        {
            return new List<string>() { 
                "Hi!",
                "Welcome to Slack!",
                "This should be easy.",
                "Have a quick tour"
            };
        }
    }
}
