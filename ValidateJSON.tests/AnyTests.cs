using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class AnyTests
    {
        [Fact]
        public void IfFirstCharacterFromAcceptedIsFirstInStringWeShouldReturnTrue()
        {
            var e = new Any("eE");
            var match = e.Match("ea");
            Assert.True(match.Success());
            Assert.Equal("a", match.RemainingText());
        }

        [Fact]
        public void IfFirstCharacterFromAcceptedIsFirstInStringWeShouldReturnTrue1()
        {
            var e = new Any("+-");
            var match = e.Match("+123");
            Assert.True(match.Success());
            Assert.Equal("123", match.RemainingText());
        }

        [Fact]
        public void IfAnyFromAcceptedIsFirstInStringWeShouldReturnTrue()
        {
            var e = new Any("*/+-");
            var match = e.Match("+123");
            Assert.True(match.Success());
            Assert.Equal("123", match.RemainingText());
        }


        [Fact]
        public void IfSecondCharacterFromAcceptedIsFirstInStringWeShouldReturnTrue()
        {
            var e = new Any("eE");
            var match = e.Match("Ea");
            Assert.True(match.Success());
            Assert.Equal("a", match.RemainingText());
        }

        [Fact]
        public void IfNoneCharacterFromAcceptedIsFirstInStringWeShouldReturnFalse()
        {
            var e = new Any("eE");
            var match = e.Match("a");
            Assert.False(match.Success());
            Assert.Equal("a", match.RemainingText());
        }

        [Fact]
        public void IfStringIsEmptyWeShouldReturnFalse()
        {
            var e = new Any("eE");
            var match = e.Match("");
            Assert.False(match.Success());
            Assert.Equal("", match.RemainingText());
        }
        [Fact]
        public void IfStringIsNullWeShouldReturnFalse()
        {
            var e = new Any("eE");
            var match = e.Match(null);
            Assert.False(match.Success());
            Assert.Null(match.RemainingText());
        }
    }
}
