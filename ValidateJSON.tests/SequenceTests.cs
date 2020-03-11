using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class SequenceTests
    {
        [Fact]
        public void SequenceOfMatchingCharactersShoudReturnTrue()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('b')
            );
            var match = ab.Match("abcd");
            Assert.True(match.Success());
            Assert.Equal("cd", match.RemainingText());
        }

        [Fact]
        public void SequenceOfNotMatchingCharactersShoudReturnFalse()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('x')
            );
            var match = ab.Match("abcd");
            Assert.False(match.Success());
            Assert.Equal("abcd", match.RemainingText());
        }

        [Fact]
        public void NullShoudReturnFalse()
        {
            var ab = new Sequence(
                new Character('a'),
                new Character('x')
            );
            var match = ab.Match(null);
            Assert.False(match.Success());
            Assert.Null(match.RemainingText());
        }
    }
}
