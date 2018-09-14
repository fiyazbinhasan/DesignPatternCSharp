using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;

namespace Bridge.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockPlatformAPI = new Mock<IPlatformAPI>();

            mockPlatformAPI.Setup(x => x.LoadMessages()).Returns(new List<string> {
                "Hi!",
                "Welcome to Slack!",
                "This should be easy.",
                "Have a quick tour" 
            });

            var slackSubscription = new FreeSubscription(mockPlatformAPI.Object) {  MaxLimitOnMessages = 3};
            Assert.Equal(3, slackSubscription.GetMessages().Count());
        }
    }
}
