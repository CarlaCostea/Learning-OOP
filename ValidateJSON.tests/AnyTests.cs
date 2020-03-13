using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class AnyTests
    {
        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var e = new Any("eE");
            var match = e.Match("ea");
            Assert.True(match.Success());
            Assert.Equal("a", match.RemainingText());
        }
    }
}
