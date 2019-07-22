using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    public class FreeSubscription : Subscription
    {
        public FreeSubscription(IPlatformApi platformApi, int maxVisibleMessages) : base(platformApi, maxVisibleMessages)
        {
            
        }
    }
}
