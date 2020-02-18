using System;
using Xunit;

namespace ValidateJSON.tests
{
    public class UnitTest1
    {
        [Fact]
        public void FirstCharacterShouldBeQuotationMark()
        {
            string input = "";
            Assert.Equal(true, Program.ValidateJsonString(input));
        }
    }
}
