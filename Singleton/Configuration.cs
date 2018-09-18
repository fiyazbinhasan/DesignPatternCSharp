using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class Configuration
    {
        private static readonly Configuration instance = new Configuration();

        static Configuration()
        {
        }

        private Configuration()
        {
        }

        public static Configuration Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
