using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    public class FreeSubscription : Subscription
    {
        public FreeSubscription(IPlatformAPI platformAPI) : base(platformAPI)
        {
            
        }

        //public override int MaxLimitOnMessages { get; set; }

        public override IEnumerable<string> GetMessages()
        {
            return _platformAPI.LoadMessages().Take(MaxLimitOnMessages);
        }
    }
}
