using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(IPlatformAPI platformAPI) : base(platformAPI)
        {

        }

        public override IEnumerable<string> GetMessages()
        {
            return _platformAPI.LoadMessages();
        }
    }
}
