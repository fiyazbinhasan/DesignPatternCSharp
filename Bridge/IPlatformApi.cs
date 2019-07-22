using System;
using System.Collections.Generic;

namespace Bridge
{
    public interface IPlatformApi
    {
        IEnumerable<string> LoadMessages();
    }
}
