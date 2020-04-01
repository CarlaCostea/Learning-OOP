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
    }
}
