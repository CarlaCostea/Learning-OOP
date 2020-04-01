using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class ValueTests
    {
        [Fact]
        public void ValidJSONShouldReturnTrue()
        {
            var value = new Value();
            Assert.True(value.Match("\"ValidJSON\"").Success());
        }

        [Fact]
        public void ValidJSONShouldReturnTrue1()
        {
            var value = new Value();
            Assert.True(value.Match("{ \"name\":\"John\", \"age\":30, \"car\":null }").Success());
        }

        [Fact]
        public void ValidJSONShouldReturnTrue2()
        {
            var value = new Value();
            Assert.True(value.Match("[ \"Ford\", \"BMW\", \"Fiat\" ]").Success());
        }
    }
}
