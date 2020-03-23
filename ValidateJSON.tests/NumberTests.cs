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
            var number = new Number();
            Assert.True(number.Match("12.2").Success());
        }

        [Fact]
        public void CorrectFloatNumberShouldReturnTrue4()
        {
            var number = new Number();
            Assert.True(number.Match("-12.12").Success());
        }
        [Fact]
        public void SubunitarShouldReturnTrue()
        {
            var number = new Number();
            Assert.False(number.Match("0.11243").Success());
        }
        [Fact]
        public void NegativeSubunitarShouldReturnTrue()
        {
            var number = new Number();
            Assert.False(number.Match("-0.12345").Success());
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
            Assert.False(number.Match("N").Success());
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
            var number = new Number();
            Assert.True(number.Match("12.123e3").Success());
        }
        [Fact]
        public void CorrectExponentialFormatShouldReturnTrue1()
        {
            var number = new Number();
            Assert.True(number.Match("12.123E+3").Success());
        }
        [Fact]
        public void CorrectExponentialFormatShouldReturnTrue2()
        {
            var number = new Number();
            Assert.True(number.Match("12.123E-2").Success());
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse()
        {
            var number = new Number();
            Assert.False(number.Match("12.123E").Success());
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse1()
        {
            var number = new Number();
            Assert.False(number.Match("12.123E+").Success());
        }
        [Fact]
        public void InvalidExponentialFormatShouldReturnFalse2()
        {
            var number = new Number();
            Assert.False(number.Match("12.123E+.").Success());
        }
    }
}
