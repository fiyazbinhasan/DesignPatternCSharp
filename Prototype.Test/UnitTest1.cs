using System;
using Xunit;

namespace Prototype.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Person husband = new Person
            {
                Name = "Jon Doe",
                Address = new Address
                {
                    FlatNo = "12/3",
                    StreetNo = "456 Main Street",
                    City = "New York",
                    Country = "USA"
                }
            };

            Person wife = new Person
            {
                Name = "Jane Doe",
                Address = new Address
                {
                    FlatNo = "7/89",
                    StreetNo = "101 Secondary Street",
                    City = "Toronto",
                    Country = "Cannada"
                }
            };

            Couple couple = new Couple
            {
                Husband = husband,
                Wife = wife,
                Address = (Address)husband.Address.Clone()
            };

            couple.Address.StreetNo = "112 Main Street";

            Assert.NotEqual(husband.Address.StreetNo, couple.Address.StreetNo);
            Assert.Equal(husband.Address.StreetNo, "456 Main Street");
        }
    }
}
