using System;
using System.Linq;
using Xunit;

namespace AbstractFactory.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            VendorFactory intel = new IntelFactory();
            Combo combo = new Combo(intel);
            var items = combo.CreateCombo();

            Assert.Contains(nameof(SkylakeI9), items);
            Assert.Contains(nameof(StrixX299), items);
        }
    }
}
