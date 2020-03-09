using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class RangeTests
    {
        [Fact]
        public void IfStringIsNullWeShouldReturnFalse()
        {
            var digit = new Range('a', 'f');
            Assert.False(digit.Match());
        }
    }
}
