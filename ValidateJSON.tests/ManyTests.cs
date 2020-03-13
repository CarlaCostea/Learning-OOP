using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class ManyTests
    {
        [Fact]
        public void DeletePatternWhileIsFoundAtTheBegginingOfTheString()
        {
            var a = new Many(new Character('a'));
            var match = a.Match("abc");
            Assert.True(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void DeletePatternWhileIsFoundAtTheBegginingOfTheString1()
        {
            var a = new Many(new Character('a'));
            var match = a.Match("aabc");
            Assert.True(match.Success());
            Assert.Equal("bc", match.RemainingText());
        }

        [Fact]
        public void DeletePatternWhileIsFoundAtTheBegginingOfTheString2()
        {
            var digits = new Many(new Range('0', '9'));
            var match = digits.Match("12345ab123");
            Assert.True(match.Success());
            Assert.Equal("ab123", match.RemainingText());
        }

        [Fact]
        public void DeletePatternWhileIsFoundAtTheBegginingOfTheString3()
        {
            var digits = new Many(new Range('0', '9'));
            var match = digits.Match(null);
            Assert.True(match.Success());
            Assert.Null(match.RemainingText());
        }
    }
}
