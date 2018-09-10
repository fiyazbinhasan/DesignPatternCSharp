using Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decorator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sandwich = new BaseSandwich();

            Assert.AreEqual(sandwich.Price, 1.00M);

            var wheatBreadSandwich = new WheatBread(sandwich);

            Assert.AreEqual(wheatBreadSandwich.Price, 2.00M);

            var hamSandwich = new Ham(wheatBreadSandwich);

            Assert.AreEqual(hamSandwich.Price, 4.00M);

            var baconSandwich = new Bacon(hamSandwich);

            Assert.AreEqual(baconSandwich.Price, 7.00M);

            // Conponent class
            // Concrete Component class
            // Decorator class
            // Concrete Decorator
        }
    }
}
