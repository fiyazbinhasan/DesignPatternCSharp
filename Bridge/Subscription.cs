using System;
using System.Collections.Generic;

namespace Bridge
{
    public abstract class Subscription
    {
        protected IPlatformAPI _platformAPI;

        public virtual int MaxLimitOnMessages { get; set; } = 0;

        public IPlatformAPI PlatformAPI
        {
            set { _platformAPI = value; }
        }

        public Subscription(IPlatformAPI platformAPI)
        {
            _platformAPI = platformAPI;
        }

        public virtual IEnumerable<string> GetMessages() {
            return _platformAPI.LoadMessages();
        }
    }
}
