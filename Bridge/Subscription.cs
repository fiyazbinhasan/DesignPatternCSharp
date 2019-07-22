using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge
{
    public abstract class Subscription
    {
        private readonly IPlatformApi _platformApi;
        private readonly int _maxVisibleMessages;

        protected Subscription(IPlatformApi platformApi, int maxVisibleMessages)
        {
            _platformApi = platformApi;
            _maxVisibleMessages = maxVisibleMessages;
        }

        public IEnumerable<string> GetMessages() {
            return _platformApi.LoadMessages().Take(_maxVisibleMessages);
        }
    }
}
