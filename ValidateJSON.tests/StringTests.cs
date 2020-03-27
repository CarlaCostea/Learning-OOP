using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class StringTests
    {
        [Fact]
        public void FirstAndLastCharactersShouldBeQuotationMark()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\"").Success());
            Assert.Equal("", @string.Match("\"\"").RemainingText());
        }

        [Fact]
        public void WhenInputContainsDoubleQuotesWeShouldReturnRemainingText()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\"\"").Success());
            Assert.Equal("\"", @string.Match("\"\"\"").RemainingText());
        }

        [Fact]
        public void WhenInputContainsBackslashWeShouldReturnFalse()
        {
            string input = "\"\\\"";
            Assert.False(ValidateString.ValidateJsonString(input));
        }
        [Fact]
        public void WhenInputContainsValidUnicodeWeShouldReturnTrueAndEmptyString()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\u0020\"").Success());
            Assert.Equal("", @string.Match("\"\\u0020\"").RemainingText());
        }

        [Fact]
        public void WhenInputContainsWrongUnicodeWeShouldReturnFalse()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\u002\"").Success());
            Assert.Equal("\"\\u002\"", @string.Match("\"\\u002\"").RemainingText());
        }

        [Fact]
        public void WhenBackslashIsPrecededByBackslashWeShouldReturnTrue()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\\\\"").Success());
            Assert.Equal("", @string.Match("\"\\\\\"").RemainingText());
        }
        [Fact]
        public void WhenSolidusIsPrecededByBackslashWeShouldReturnTrue()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\/\"").Success());
            Assert.Equal("", @string.Match("\"\\/\"").RemainingText());
        }
        [Fact]
        public void WhenDoubleQuotesArePrecededByBackslashWeShouldReturnTrue()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\\"\"").Success());
            Assert.Equal("", @string.Match("\"\\\"\"").RemainingText());
        }
        [Fact]
        public void RandomValidTest0()
        {
            var @string = new String();
            Assert.True(@string.Match("\"Test\"").Success());
            Assert.Equal("", @string.Match("\"Test\"").RemainingText());
        }
        [Fact]
        public void RandomInvalidTest0()
        {
            var @string = new String();
            Assert.True(@string.Match("Test\"").Success());
            Assert.Equal("Test\"", @string.Match("Test\"").RemainingText());
        }
        [Fact]
        public void RandomValidTest1()
        {
            var @string = new String();
            Assert.True(@string.Match("\"Test\\u0097\"").Success());
            Assert.Equal("", @string.Match("\"Test\\u0097\"").RemainingText());
        }

        [Fact]
        public void RandomValidTest2()
        {
            var @string = new String();
            Assert.True(@string.Match("\"Test\\u0097\\nAnother line\"").Success());
            Assert.Equal("", @string.Match("\"Test\\u0097\\nAnother line\"").RemainingText());
        }
        [Fact]
        public void RandomValidTest3()
        {
            var @string = new String();
            Assert.True(@string.Match("\"\\nAnother line\"").Success());
            Assert.Equal("", @string.Match("\"\\nAnother line\"").RemainingText());
        }
        [Fact]
        public void RandomValidTest4()
        {
            var @string = new String();
            Assert.True(@string.Match("\"Backspace\\bAnother line\"").Success());
            Assert.Equal("", @string.Match("\"Backspace\\bAnother line\"").RemainingText());
        }
    }
}
