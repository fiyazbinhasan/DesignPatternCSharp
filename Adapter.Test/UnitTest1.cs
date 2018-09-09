using Adapter.Interface;
using System;
using Xunit;

namespace Adapter.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IComputer computer = new Computer();
            computer.PowerOn();

            ThirdPartyComputerAdaptee thirdPartyComputer = new ThirdPartyComputerAdaptee();

            IComputer adapter = new ThirdPartyComputerAdpter(thirdPartyComputer);
            adapter.PowerOn();

            Assert.True(computer.IsOn);
            Assert.True(thirdPartyComputer.IsOn);
        }
    }
}
