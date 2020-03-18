using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class OptionalTests
    {
        [Fact]
        public void ConsumePatternIfIsFoundAtTheBegginingOfTheString()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match("abc");
            Assert.True(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ConsumePatternIfIsFoundAtTheBegginingOfTheString1()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match("aabc");
            Assert.True(match.Success());
            Assert.Equal("abc", match.RemainingText());
        }

        [Fact]
        public void ReturnTrueAndTheStringIfPatternIsNotFound()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match("bc");
            Assert.True(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void ReturnTrueForEmptyString()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match("");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void ReturnTrueForNull()
        {
            var a = new Optional(new Character('a'));
            var match = a.Match(null);
            Assert.True(match.Success());
            Assert.Null(match.RemainingText());
        }
    }
}
