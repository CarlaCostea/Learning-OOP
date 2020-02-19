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
            Assert.True(Program.IsWrappedInDoubleQuotes(input));
        }

        [Fact]
        public void WhenContentIsNullWeShouldReturnTrue()
        {
            string input = "\"\"";
            Assert.True(Program.ValidateJsonString(input));
        }

        [Fact]
        public void WhenInputContainsControlCharactersWeShouldReturnFalse()
        {
            string input = "\"\\u\"";
            Assert.False(Program.ValidateJsonString(input));
        }
        [Fact]
        public void WhenInputContainsDoubleQuotesWeShouldReturnFalse()
        {
            string input = "\"\"\"";
            Assert.False(Program.ValidateJsonString(input));
        }

        [Fact]
        public void WhenInputContainsBackslashWeShouldReturnFalse()
        {
            string input = "\"\\\"";
            Assert.False(Program.ValidateJsonString(input));
        }
    }
}
