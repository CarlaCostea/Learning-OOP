using System;
using Xunit;

namespace ValidateJSON.tests
{
    public class ValidateJson
    {
        [Fact]
        public void FirstAndLastCharactersShouldBeQuotationMark()
        {
            string input = "\"\"";
            Assert.Equal(true, Program.IsWrappedInDoubleQuotes(input));
        }

        [Fact]
        public void WhenContentIsNullWeShouldReturnTrue()
        {
            string input = "\"\"";
            Assert.Equal(true, Program.ValidateJsonString(input));
        }

        [Fact]
        public void WhenInputContainsOnlyLettersWeShouldReturnTrue()
        {
            string input = "\"ana\"";
            Assert.Equal(true, Program.ValidateJsonString(input));
        }
    }
}
