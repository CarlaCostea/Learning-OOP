using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class CharacterTests
    {
        [Fact]
        public void IfStringIsNullWeShouldReturnFalse()
        {
            var x = new Character('x');
            var match = x.Match(null);
            Assert.False(match.Success());
            Assert.Null(match.RemainingText());
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var x = new Character('x');
            var match = x.Match("");
            Assert.False(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var x = new Character('x');
            var match = x.Match("xtb");
            Assert.True(match.Success());
            Assert.Equal("tb", match.RemainingText());
        }

        [Fact]
        public void IfFirstLetterIsNotInStringWeShouldReturnFalse()
        {
            var x = new Character('x');
            var match = x.Match("wtb");
            Assert.False(match.Success());
            Assert.Equal("wtb", match.RemainingText());
        }
    }
}
