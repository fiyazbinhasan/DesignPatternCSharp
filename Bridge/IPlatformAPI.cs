using System;
using System.Collections.Generic;

namespace Bridge
{
    public interface IPlatformAPI
    {
        IEnumerable<string> LoadMessages();
    }
}
