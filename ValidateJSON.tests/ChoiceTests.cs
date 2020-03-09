using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ValidateJSON.tests
{
    public class ChoiceTests
    {
        [Fact]
        public void MatchReturnsTrueForTextMatchingTheFirstChoicePattern()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            Assert.True(digit.Match("0FE"));
        }
        [Fact]
        public void MatchReturnsFalseForTextThatDoesNotMatchAnyChoicePatterns()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            Assert.False(digit.Match("FE"));
        }
        [Fact]
        public void MatchReturnsTrueForTextMatchingTheSecondChoicePattern()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9')
            );
            Assert.True(digit.Match("1FE"));
        }
        [Fact]
        public void MatchReturnsTrueForTextMatchingChoiceOfChoicesPatterns()
        {
            var digit = new Choice(
                 new Character('0'),
                 new Range('1', '9')
            );
            var hex = new Choice(
                    digit,
                    new Choice(
                        new Range('a', 'f'),
                        new Range('A', 'F')
                        )
            );

            Assert.True(hex.Match("1FE"));
        }

        [Fact]
        public void MatchReturnsFalseForTextNotMatchingChoiceOfChoicesPatterns()
        {
            var digit = new Choice(
                 new Character('0'),
                 new Range('1', '9')
            );
            var hex = new Choice(
                    digit,
                    new Choice(
                        new Range('a', 'f'),
                        new Range('A', 'F')
                        )
            );

            Assert.False(hex.Match("gFE"));
        }
    }
}
