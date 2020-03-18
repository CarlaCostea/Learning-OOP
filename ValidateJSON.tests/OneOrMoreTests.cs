using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class OneOrMoreTests
    {
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match("123");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString1()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match("123a");
            Assert.True(match.Success());
            Assert.Equal("a", match.RemainingText());
        }

        [Fact]
        public void ReturnFalseAndTheStringIfPatternIsNotFound()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match("bc");
            Assert.False(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }
        [Fact]
        public void ReturnFalseForEmptyString()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match("");
            Assert.False(match.Success());
            Assert.Equal("", match.RemainingText());
        }
        [Fact]
        public void ReturnFalseForNull()
        {
            var a = new OneOrMore(new Range('0', '9'));
            var match = a.Match(null);
            Assert.False(match.Success());
            Assert.Null(match.RemainingText());
        }
    }
}
