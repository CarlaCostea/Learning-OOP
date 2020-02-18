using System;
using Xunit;

namespace ValidateJSON.tests
{
    public class ValidateJson
    {
        [Fact]
        public void FirstCharacterShouldBeQuotationMark()
        {
            string input = "\"";
            Assert.Equal(true, Program.ValidateJsonString(input));
        }
    }
}
