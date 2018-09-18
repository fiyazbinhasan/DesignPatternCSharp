using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Singleton.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Configuration instanceOne = Configuration.Instance;
            Configuration instanceTwo = Configuration.Instance;

            Assert.Equal(instanceOne, instanceTwo);
        }
    }
}
