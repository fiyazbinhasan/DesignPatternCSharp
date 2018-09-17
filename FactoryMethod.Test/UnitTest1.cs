using System;
using Xunit;

namespace FactoryMethod.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IUserFactory factory = new UserFactory();

            var userOne = factory.CreateUser("SUPPLIER");
            var userTwo = factory.CreateUser("Customer");

            Assert.IsType<Supplier>(userOne);
            Assert.IsType<Customer>(userTwo);
        }
    }
}
