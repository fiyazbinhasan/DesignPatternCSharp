using System;
using Moq;
using Xunit;

namespace Proxy.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockRepo = new Mock<ICustomerRepository>();

            mockRepo.Setup(x => x.GetById(1)).Returns(new Customer { });

            var cachedRepo = new CachedCustomerRepository(mockRepo.Object);

            cachedRepo.GetById(1);
            cachedRepo.GetById(1);

            mockRepo.Verify(x => x.GetById(1), Times.Once);
        }
    }
}