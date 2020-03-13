using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class OptionalTests
    {
        [Fact]
        public void ConsumePatternIfIsFoundAtTheBegginingOfTheString()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match("abc");
            Assert.True(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }
    }
}
