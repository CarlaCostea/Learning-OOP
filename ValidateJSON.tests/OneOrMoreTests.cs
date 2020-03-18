using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class OneOrMoreTests
    {
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOneTimeInString()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match("123");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }
    }
}
