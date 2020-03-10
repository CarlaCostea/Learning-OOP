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
            var match = new Match(null, false);
            Assert.Equal(match, x.Match(null));
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var x = new Character('x');
            var match = new Match(null, false);
            Assert.Equal(match, x.Match(null));
        }

        [Fact]
        public void IfFirstLetterIsInStringWeShouldReturnTrue()
        {
            var x = new Character('x');
            var match = new Match("tb", true);
            Assert.Equal(match, x.Match("xtb"));
        }

        [Fact]
        public void IfFirstLetterIsNotInStringWeShouldReturnFalse()
        {
            var x = new Character('x');
            var match = new Match("wtb", false);
            Assert.Equal(match, x.Match("wtb"));
        }
    }
}
