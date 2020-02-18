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
            Assert.Equal(true, Program.ValidateJsonString(input));
        }
    }
}
