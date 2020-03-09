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
            Assert.False(digit.Match(null));
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var digit = new Range('a', 'f');
            Assert.False(digit.Match(""));
        }

        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var digit = new Range('a', 'f');
            Assert.True(digit.Match("btg"));
        }

        [Fact]
        public void IfFirstLetterIsNotInStringWeShouldReturnTrue()
        {
            var digit = new Range('a', 'f');
            Assert.False(digit.Match("wtg"));
        }
    }
}
