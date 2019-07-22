using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(IPlatformApi platformApi) : base(platformApi, Int32.MaxValue)
        {
            
        }
    }
}
