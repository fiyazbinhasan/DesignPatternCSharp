using System;
using System.Linq;
using Xunit;

namespace TemplateMethod.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Theme flatly = new Flatly();
            var flatlyFiles = flatly.DownloadBundle(true);

            Assert.Equal(5, flatlyFiles.Count());

            Theme cosmo = new Cosmo();
            var cosmoFiles = flatly.DownloadBundle(false);

            Assert.Equal(3, cosmoFiles.Count());
        }
    }
}
