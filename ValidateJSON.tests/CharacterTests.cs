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
            Assert.False(x.Match(null));
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var x = new Character('x');
            Assert.False(x.Match(""));
        }

        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var x = new Character('x');
            Assert.True(x.Match("xtg"));
        }

        [Fact]
        public void IfFirstLetterIsNotInStringWeShouldReturnTrue()
        {
            var x = new Character('x');
            Assert.False(x.Match("wtg"));
        }
    }
}
