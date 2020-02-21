using System;
using Xunit;
using ValidateJSON;

namespace ValidateJSONNumberTests
{
    public class ValidateJSONNumberTests
    {
        [Fact]
        public void WhenContentIsNullWeShouldReturnTrue()
        {
            string input = "12.123e3";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }

    }
}
