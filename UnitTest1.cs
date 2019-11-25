using System;
using Xunit;

namespace TeamCity.DupeCount.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldFail()
        {
            Assert.True(false);
        }
    }
}
