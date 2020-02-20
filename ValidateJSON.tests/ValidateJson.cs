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
        public void WhenInputContainsSolidusShouldReturnFalse()
        {
            string input = "\"/\"";
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
        [Fact]
        public void WhenInputContainsControlCharactersWeShouldReturnFalse()
        {
            string input = "\"^W\"";
            Assert.False(Program.ValidateJsonString(input));
        }
        [Fact]
        public void WhenBackslashIsPrecededByBackslashWeShouldReturnTrue()
        {
            string input = "\"\\\\\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void WhenSolidusIsPrecededByBackslashWeShouldReturnTrue()
        {
            string input = "\"\\/\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void WhenDoubleQuotesArePrecededByBackslashWeShouldReturnTrue()
        {
            string input = "\"\\\"\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void RandomValidTest0()
        {
            string input = "\"Test\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void RandomInvalidTest0()
        {
            string input = "Test\"";
            Assert.False(Program.ValidateJsonString(input));
        }
        [Fact]
        public void RandomValidTest1()
        {
            string input = "\"Test\\u0097\"";
            Assert.True(Program.ValidateJsonString(input));
        }

        [Fact]
        public void RandomValidTest2()
        {
            string input = "\"Test\\u0097\\nAnother line\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void RandomValidTest3()
        {
            string input = "\"\\nAnother line\"";
            Assert.True(Program.ValidateJsonString(input));
        }
        [Fact]
        public void RandomValidTest4()
        {
            string input = "\"Backspace\\bAnother line\"";
            Assert.True(Program.ValidateJsonString(input));
        }

    }
}
