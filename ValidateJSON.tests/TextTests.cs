using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class TextTests
    {
        [Fact]
        public void IfTextStartsWithPrexifxWeShouldReturnTrue()
        {
            var trueCase = new Text("true");
            var match = trueCase.Match("true");
            Assert.True(match.Success());
            Assert.Equal("", match.RemainingText());
        }

        [Fact]
        public void IfTextStartsWithPrexifxWeShouldReturnTrue1()
        {
            var trueCase = new Text("true");
            var match = trueCase.Match("trueX");
            Assert.True(match.Success());
            Assert.Equal("X", match.RemainingText());
        }

        [Fact]
        public void IfPrefixIsEmptyWeShouldReturnTrue()
        {
            var empty = new Text("");
            var match = empty.Match("truX");
            Assert.True(match.Success());
            Assert.Equal("truX", match.RemainingText());
        }
    }
}
