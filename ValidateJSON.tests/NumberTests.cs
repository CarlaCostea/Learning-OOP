using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class NumberTests
    {
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
        [Fact]
        public void SubunitarShouldReturnTrue()
        {
            string input = "0.1312";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void NegativeSubunitarShouldReturnTrue()
        {
            string input = "-0.1312";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void TreatsZeroCorecttly()
        {
            var number = new Number();
            Assert.True(number.Match("0").Success());
            Assert.False(number.Match("00").Success());
        }
        [Fact]
        public void NumberPreceededByZeroShouldReturnFalse()
        {
            var number = new Number();
            Assert.False(number.Match("01").Success());
        }
        [Fact]
        public void OneDigitShouldReturnTrue()
        {
            var number = new Number();
            Assert.True(number.Match("1").Success());
        }
        [Fact]
        public void NaturalsShouldReturnTrue()
        {
            var number = new Number();
            Assert.True(number.Match("6701").Success());
        }
        [Fact]
        public void NegativeShouldReturnTrue()
        {
            var number = new Number();
            Assert.True(number.Match("-6701").Success());
        }
        [Fact]
        public void NegativeDigitShouldReturnTrue()
        {
            var number = new Number();
            Assert.True(number.Match("-1").Success());
        }
        [Fact]
        public void ExponentialShouldReturnTrue()
        {
            string input = "12.123e3";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void CorrectExponentialFormatShouldReturnTrue1()
        {
            string input = "12.123E+3";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void CorrectExponentialFormatShouldReturnTrue2()
        {
            string input = "12.123E-2";
            Assert.True(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse()
        {
            string input = "12.123E";
            Assert.False(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse1()
        {
            string input = "12.123E+";
            Assert.False(ValidateJSONNumber.ValidateInput(input));
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse2()
        {
            string input = "12.123E+.";
            Assert.False(ValidateJSONNumber.ValidateInput(input));
        }
    }
}
