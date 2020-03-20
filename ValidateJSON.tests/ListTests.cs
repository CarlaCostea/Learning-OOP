using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class ListTests
    {
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match("1,2,3");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString1()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match("1,2,3,");
            Assert.True(match.Success());
            Assert.Equal(",", match.RemainingText());
        }
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString2()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match("1a");
            Assert.True(match.Success());
            Assert.Equal("a", match.RemainingText());
        }
        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString3()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match("abc");
            Assert.True(match.Success());
            Assert.Equal("abc", match.RemainingText());
        }

        [Fact]
        public void ReturnTrueAndEmptyStringForEmptyString()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match("");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void ReturnTrueAndNullForNull()
        {
            var a = new List(new Range('0', '9'), new Character(','));
            var match = a.Match(null);
            Assert.True(match.Success());
            Assert.Null(match.RemainingText());
        }

        [Fact]
        public void ConsumePatternIfIsFoundAtLeastOnceInString4()
        {
            var digits = new OneOrMore(new Range('0', '9'));
            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequence(whitespace, new Character(';'), whitespace);
            var list = new List(digits, separator);
            var match = list.Match("1; 22  ;\n 333 \t; 22");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }
    }
}
