using System;
using Xunit;
using ValidateJSON;

namespace ValidateJSONNumberTests
{
    public class ValidateJSONNumberTests
    {
        //[Fact]
        //public void CorrectFloatNumberShouldReturnTrue()
        //{
        //    string input = "12.123e3";
        //    Assert.True(ValidateJSONNumber.ValidateInput(input));
        //}
        //[Fact]
        //public void CorrectFloatNumberShouldReturnTrue1()
        //{
        //    string input = "12.123E+3";
        //    Assert.True(ValidateJSONNumber.ValidateInput(input));
        //}
        //[Fact]
        //public void CorrectFloatNumberShouldReturnTrue2()
        //{
        //    string input = "12.123E-2";
        //    Assert.True(ValidateJSONNumber.ValidateInput(input));
        //}
        [Fact]
        public void CorrectFloatNumberShouldReturnTrue3()
        {
            string input = "12.12";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }

        [Fact]
        public void CorrectFloatNumberShouldReturnTrue4()
        {
            string input = "-12.12";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        //[Fact]
        //public void NegativeNumberShouldReturnTrue()
        //{
        //    string input = "12.123E-2";
        //    Assert.True(ValidateJSONNumber.ValidateInput(input));
        //}
        //[Fact]
        //public void SubunitarShouldReturnTrue()
        //{
        //    string input = "0.1312";
        //    Assert.True(ValidateJSONNumber.ValidateInput(input));
        //}
        [Fact]
        public void ZeroShouldReturnTrue()
        {
            string input = "0";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void NumberPreceededByZeroShouldReturnFalse()
        {
            string input = "01";
            Assert.False(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void OneDigitShouldReturnTrue()
        {
            string input = "1";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void NaturalsShouldReturnTrue()
        {
            string input = "647561";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void NegativeShouldReturnTrue()
        {
            string input = "-647561";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void NegativeDigitShouldReturnTrue()
        {
            string input = "-1";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
    }
}
