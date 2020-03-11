using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class RangeTests
    {
        [Fact]
        public void IfStringIsNullWeShouldReturnFalse()
        {
            var digit = new Range('a', 'f');
            var match = digit.Match(null);
            Assert.False(match.Success());
            Assert.Null( match.RemainingText());
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var digit = new Range('a', 'f');
            var match = digit.Match("");
            Assert.False(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var digit = new Range('a', 'f');
            var match = digit.Match("btg");
            Assert.True(match.Success());
            Assert.Equal("tg", match.RemainingText());
        }

        [Fact]
        public void IfFirstLetterIsNotInStringWeShouldReturnTrue()
        {
            var digit = new Range('a', 'f');
            var match = digit.Match("wtg");
            Assert.False(match.Success());
        }
    }
}
